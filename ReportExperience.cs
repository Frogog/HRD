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
using System.Diagnostics;
using System.Data.SqlClient;
using Spire.Doc.Fields;

namespace HRD
{
    public partial class ReportExperience : Form
    {
        public ReportExperience()
        {
            InitializeComponent();
        }
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=LAPTOP-3UFK0395\\SQLEXPRESS;Initial Catalog=HRD_DB;Integrated Security=True";
        private List<Resp> resp = new List<Resp>();
        private void createB_Click(object sender, EventArgs e)
        {

            if (!ValidateReport()) return;
            string sql = "SELECT Employee.ID_Emp, CAST(Employee.Name AS NVARCHAR(100)) AS Name, Employee.LName, Employee.Pat, CAST(Post.Name AS NVARCHAR(100)) AS Name_Po, CAST(Qualification.Name AS NVARCHAR(100)) AS Name_Qual, COUNT(CASE WHEN Employee_Project.Resp = 1 THEN 1 END) AS Amount, CASE WHEN COUNT(DISTINCT CASE WHEN Project.FDE IS NOT NULL THEN Project.ID_Pr END) = 0 THEN 0 ELSE (COUNT(DISTINCT CASE WHEN Project.FDE IS NOT NULL AND Project.FDE <= Project.PDE THEN Project.ID_Pr END) * 100) / COUNT(DISTINCT CASE WHEN Project.FDE IS NOT NULL THEN Project.ID_Pr END) END AS Rate FROM Employee INNER JOIN Employee_Project ON Employee.ID_Emp = Employee_Project.Emp_ID INNER JOIN Project ON Employee_Project.Pr_ID = Project.ID_Pr INNER JOIN Post ON Employee.Po_ID = Post.ID_Po INNER JOIN Qualification ON Employee.Qual_ID = Qualification.ID_Qual WHERE Project.FDE IS NOT NULL AND Resp = 1 GROUP BY Employee.ID_Emp, CAST(Employee.Name AS NVARCHAR(100)), Employee.LName, Employee.Pat, CAST(Post.Name AS NVARCHAR(100)), CAST(Qualification.Name AS NVARCHAR(100)) ORDER BY Amount DESC;";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            SqlDataReader inv = command.ExecuteReader();

            Document doc = new Document();
            doc.LoadFromFile(@"ReportExperienceExample.docx");
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

                // Количество проектов
                p2 = DataRow.Cells[4].AddParagraph();
                AppendFormattedText(p2, inv["Amount"].ToString());

                // Процент успешных проектов
                p2 = DataRow.Cells[5].AddParagraph();
                AppendFormattedText(p2, inv["Rate"].ToString() + "%");

                i++;
            }
            connect.Close();

            sql = "SELECT Post.Name AS PostName FROM Employee INNER JOIN Post ON Employee.Po_ID = Post.ID_Po WHERE Employee.ID_Emp = " + resp[comboBox1.SelectedIndex].id + ";";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            command = connect.CreateCommand();
            command.CommandText = sql;
            string PostName = command.ExecuteScalar().ToString();
            doc.Replace("#Post#", PostName, true, true);
            connect.Close();

            doc.SaveToFile("ReportExperience.docx");
            Process.Start(@"ReportExperience.docx");
        }
        private void UpdateResp()
        {
            resp.Clear();
            comboBox1.Items.Clear();
            string sql = "SELECT ID_Emp, LName, Employee.Name, Employee.Pat, Qualification.Name AS QualName, Post.Name AS PostName FROM Employee INNER JOIN Qualification ON Employee.Qual_ID = Qualification.ID_Qual INNER JOIN Post ON Employee.Po_ID = Post.ID_Po";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            SqlDataReader inv = command.ExecuteReader();
            comboBox1.Items.Add("Не выбрано");
            resp.Add(new Resp("Не выбрано", "Не выбрано"));
            while (inv.Read())
            {
                string lastName = inv["LName"].ToString();
                string firstName = inv["Name"].ToString();
                string patronymic = inv["Pat"].ToString();

                string FIO = lastName;
                if (!string.IsNullOrEmpty(firstName))
                    FIO += " " + firstName.Substring(0, Math.Min(1, firstName.Length)) + ".";
                if (!string.IsNullOrEmpty(patronymic))
                    FIO += " " + patronymic.Substring(0, Math.Min(1, patronymic.Length)) + ".";
                comboBox1.Items.Add(FIO);
                resp.Add(new Resp(inv["ID_Emp"].ToString(), FIO));
            }
            comboBox1.SelectedIndex = 0;
        }
        private void ReportExperience_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            //this.employeeTableAdapter.Fill(this.hRD_DBDataSet.Employee);
            UpdateResp();
        }
        private bool ValidateReport()
        {
            if (comboBox1.Text == "Не выбрано")
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
                    UpdateResp();
                    if (responsable != "")
                    {
                        int index = resp.FindIndex(p => p.id == responsable);
                        if (index != -1)
                        {
                            comboBox1.SelectedIndex = index;
                        }
                    }
                }
            }
        }
    }
}
