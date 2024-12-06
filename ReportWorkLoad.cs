using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace HRD
{
    public partial class ReportWorkLoad : Form
    {
        public ReportWorkLoad()
        {
            InitializeComponent();
        }
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=LAPTOP-3UFK0395\\SQLEXPRESS;Initial Catalog=HRD_DB;Integrated Security=True";
        private void ReportWorkLoad_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
        }

        private void createB_Click(object sender, EventArgs e)
        {
            if (!ValidateReport()) return;
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "GetEmployeeProjectCountByDateRange";
            command.Parameters.AddWithValue("@startDate", dateTimePicker1.Value.ToString());
            command.Parameters.AddWithValue("@endDate", dateTimePicker2.Value.ToString());
            SqlDataReader inv = command.ExecuteReader();
            Spire.Doc.Document doc = new Spire.Doc.Document();
            doc.LoadFromFile(@"ReportWorkloadExample.docx");
            doc.Replace("#DateStart#", dateTimePicker1.Value.ToShortDateString(), true, true);
            doc.Replace("#DateEnd#", dateTimePicker2.Value.ToShortDateString(), true, true);
            doc.Replace("#Post#", "Программист", true, true);
            doc.Replace("#DateToday#", DateTime.Today.ToString("dd.MM.yyyy"), true, true);
            doc.Replace("#Name#",comboBox1.Text,true,true);
            Spire.Doc.Section section = doc.Sections[0];
            Spire.Doc.Table table = section.Tables[0] as Spire.Doc.Table;
            int i = 0;
            while (inv.Read())
            {
                table.AddRow();
                TableRow DataRow = table.Rows[i + 1];

                // Функция для настройки параграфа
                void SetupParagraph(Paragraph p)
                {
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    // Правильное форматирование текста
                    TextRange textRange = p.AppendText("");
                    textRange.CharacterFormat.FontName = "Times New Roman";
                    textRange.CharacterFormat.FontSize = 10;
                }

                // Номер
                Paragraph p2 = DataRow.Cells[0].AddParagraph();
                SetupParagraph(p2);
                TextRange text = p2.AppendText((i + 1).ToString());
                text.CharacterFormat.FontName = "Times New Roman";
                text.CharacterFormat.FontSize = 10;

                // ФИО
                p2 = DataRow.Cells[1].AddParagraph();
                SetupParagraph(p2);
                string lastName = inv["LName"].ToString();
                string firstName = inv["Name"].ToString();
                string patronymic = inv["Pat"].ToString();

                string FIO = lastName;
                if (!string.IsNullOrEmpty(firstName))
                    FIO += " " + firstName.Substring(0, Math.Min(1, firstName.Length)) + ".";
                if (!string.IsNullOrEmpty(patronymic))
                    FIO += " " + patronymic.Substring(0, Math.Min(1, patronymic.Length)) + ".";
                text = p2.AppendText(FIO);
                text.CharacterFormat.FontName = "Times New Roman";
                text.CharacterFormat.FontSize = 10;

                // Должность
                p2 = DataRow.Cells[2].AddParagraph();
                SetupParagraph(p2);
                text = p2.AppendText(inv["Name_Po"].ToString());
                text.CharacterFormat.FontName = "Times New Roman";
                text.CharacterFormat.FontSize = 10;

                // Квалификация
                p2 = DataRow.Cells[3].AddParagraph();
                SetupParagraph(p2);
                text = p2.AppendText(inv["Name_Qual"].ToString());
                text.CharacterFormat.FontName = "Times New Roman";
                text.CharacterFormat.FontSize = 10;

                // Количество проектов
                p2 = DataRow.Cells[4].AddParagraph();
                SetupParagraph(p2);
                text = p2.AppendText(inv["ProjectCount"].ToString());
                text.CharacterFormat.FontName = "Times New Roman";
                text.CharacterFormat.FontSize = 10;

                i++;
            }

            doc.SaveToFile("ReportWorkload.docx");
            connect.Close();
            this.Close();
            Process.Start(@"ReportWorkload.docx");
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
                ShowError("Проверяющий должен быть выбран!", comboBox1);
                return false;
            }
            return true;
        }
        private void ShowError(string message, Control control)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            control.Focus();
        }
    }
}
