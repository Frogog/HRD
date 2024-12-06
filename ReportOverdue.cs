using Spire.Doc.Documents;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using Spire.Doc.Fields;

namespace HRD
{
    public partial class ReportOverdue : Form
    {
        public ReportOverdue()
        {
            InitializeComponent();
        }
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=LAPTOP-3UFK0395\\SQLEXPRESS;Initial Catalog=HRD_DB;Integrated Security=True";
        String[][] testData = {
            new String[]{ "Проект1", "10.10.2020", "10.10.2021"},
            new String[]{ "Проект2","10.12.2020","10.05.2021"},
            new String[]{ "Проект3", "10.03.2021", "10.05.2021" },
            };
        private void createB_Click(object sender, EventArgs e)
        {
            if (!ValidateReport()) return;
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "Overdue";
            command.Parameters.AddWithValue("@startDate", dateTimePicker1.Value.ToString());
            command.Parameters.AddWithValue("@endDate", dateTimePicker2.Value.ToString());
            SqlDataReader inv = command.ExecuteReader();
            Document doc = new Document();
            doc.LoadFromFile(@"ReportOverdueExample.docx");
            doc.Replace("#DateStart#", dateTimePicker1.Value.ToShortDateString(), true, true);
            doc.Replace("#DateEnd#", dateTimePicker2.Value.ToShortDateString(), true, true);
            doc.Replace("#Post#", "Программист", true, true);
            doc.Replace("#DateToday#", DateTime.Today.ToString("dd.MM.yyyy"), true, true);
            doc.Replace("#Name#", comboBox1.Text, true, true);
            Section section = doc.Sections[0];
            Table table = section.Tables[0] as Table;
            int i = 0;
            void AppendFormattedText(Paragraph p, string text)
            {
                p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
                TextRange range = p.AppendText(text);
                range.CharacterFormat.FontName = "Times New Roman";
                range.CharacterFormat.FontSize = 10;
            }

            while (inv.Read())
            {
                table.AddRow();
                TableRow DataRow = table.Rows[i + 1];

                // Номер
                Paragraph p2 = DataRow.Cells[0].AddParagraph();
                AppendFormattedText(p2, (i + 1).ToString());

                // ФИО
                p2 = DataRow.Cells[1].AddParagraph();
                string lastName = inv["LName"].ToString();
                string firstName = inv["Name"].ToString();
                string patronymic = inv["Pat"].ToString();

                string FIO = lastName;
                if (!string.IsNullOrEmpty(firstName))
                    FIO += " " + firstName.Substring(0, Math.Min(1, firstName.Length)) + ".";
                if (!string.IsNullOrEmpty(patronymic))
                    FIO += " " + patronymic.Substring(0, Math.Min(1, patronymic.Length)) + ".";
                AppendFormattedText(p2, FIO);

                // Должность
                p2 = DataRow.Cells[2].AddParagraph();
                AppendFormattedText(p2, inv["Name_Po"].ToString());

                // Квалификация
                p2 = DataRow.Cells[3].AddParagraph();
                AppendFormattedText(p2, inv["Name_Qual"].ToString());

                // Количество опоздавших проектов
                p2 = DataRow.Cells[4].AddParagraph();
                AppendFormattedText(p2, inv["Late"].ToString());

                // Количество не опоздавших проектов
                p2 = DataRow.Cells[5].AddParagraph();
                AppendFormattedText(p2, inv["NotLate"].ToString());

                // Процент успешных проектов
                p2 = DataRow.Cells[6].AddParagraph();
                AppendFormattedText(p2, inv["Rate"].ToString() + "%");

                i++;
            }
            connect.Close();


            string sql = "SELECT Post.Name AS PostName FROM Employee INNER JOIN Post ON Employee.Po_ID = Post.ID_Po WHERE Employee.ID_Emp = "+comboBox1.SelectedValue+";";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            command = connect.CreateCommand();
            command.CommandText = sql;
            string PostName = command.ExecuteScalar().ToString();
            doc.Replace("#Post#", PostName, true, true);
            connect.Close();

            doc.SaveToFile("ReportOverdue.docx");
            this.Close();
            Process.Start(@"ReportOverdue.docx");
        }

        private void ReportOverdue_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.hRD_DBDataSet.Employee);
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
        }
        private bool ValidateReport()
        {
            DateTime currentDate = DateTime.Now.Date;
            // Дата создания не может быть в будущем
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                ShowError("Дата начала не может быть позже даты окончания!", dateTimePicker1);
                return false;
            }
            if (dateTimePicker1.Value.Date > currentDate)
            {
                ShowError("Дата начала не может быть в будущем!", dateTimePicker1);
                return false;
            }
            if (comboBox1.SelectedValue == null)
            {
                ShowError("Составляющий должен быть выбран!", comboBox1);
                return false;
            }
            return true;
        }
        private void ShowError(string message, Control control)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            control.Focus();
        }

        private void checkQualificationB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllEmployeeForm>().FirstOrDefault() == null)
            {
                ShowAllEmployeeForm showAllEmployeeForm = new ShowAllEmployeeForm();
                showAllEmployeeForm.Tag = "checkReportResponsable";
                DialogResult result = showAllEmployeeForm.ShowDialog();
                if ((result == DialogResult.OK) || (result == DialogResult.Cancel))
                {
                    string responsable = showAllEmployeeForm.selectedResponsable;
                    this.employeeTableAdapter.Fill(this.hRD_DBDataSet.Employee);
                    if (responsable != "") comboBox1.SelectedValue = responsable;
                }
            }
        }
    }
}
