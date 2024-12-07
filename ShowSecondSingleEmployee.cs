using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRD
{
    public partial class ShowSecondSingleEmployee : Form
    {
        public ShowSecondSingleEmployee(string id_e)
        {
            this.id_e = id_e;
            InitializeComponent();
        }
        private string id_e;
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=LAPTOP-3UFK0395\\SQLEXPRESS;Initial Catalog=HRD_DB;Integrated Security=True";

        private void ShowSecondSingleEmployee_Load(object sender, EventArgs e)
        {
            string sql = "SELECT ID_Emp, LName, Employee.Name as Name, Pat, DBirth, PSeries, PNumber, PWho, PWhen, Reg, Res, Email, Tg, Phone, Post.Name AS PostName,Qualification.Name AS QualName FROM Employee INNER JOIN Post ON Employee.Po_ID = Post.ID_Po INNER JOIN Qualification ON Employee.Qual_ID = Qualification.ID_Qual WHERE ID_Emp=" + id_e + "";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command = connect.CreateCommand();
            command.CommandText = sql;
            SqlDataReader inv = command.ExecuteReader();
            while (inv.Read())
            {
                LNameTextBox.Text = inv["LName"].ToString();
                NameTextBox.Text = inv["Name"].ToString();
                PatTextBox.Text = inv["Pat"].ToString();
                BirthDate.Text = Convert.ToDateTime(inv["DBirth"]).ToShortDateString();

                // Паспортные данные
                PSeriesTextBox.Text = inv["PSeries"].ToString();
                PNumberTextBox.Text = inv["PNumber"].ToString();
                WhoTextBox.Text = inv["PWho"].ToString();
                WhenDate.Text = Convert.ToDateTime(inv["PWhen"]).ToShortDateString();
                RegTextBox.Text = inv["Reg"].ToString();
                ResTextBox.Text = inv["Res"].ToString();

                // Контактные данные
                PhoneTextBox.Text = inv["Phone"].ToString();
                EmailTextBox.Text = inv["Email"].ToString();
                TgTextBox.Text = inv["Tg"].ToString();

                // Должностные данные
                PostCombo.Text = inv["PostName"].ToString();
                QualCombo.Text = inv["QualName"].ToString();
            }
            sql = "SELECT Skill_ID, Name, Prof FROM Skill INNER JOIN Employee_Skill ON ID_Skill = Skill_ID WHERE Emp_ID=" + id_e + ";";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            command = connect.CreateCommand();
            command.CommandText = sql;
            inv = command.ExecuteReader();
            string[] row = new string[3];
            while (inv.Read())
            {
                dataGridView2.Rows.Add(inv["Skill_ID"].ToString(), inv["Name"].ToString(), inv["Prof"].ToString());
            }
            connect.Close();
        }
    }
}
