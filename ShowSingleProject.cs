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
    public partial class ShowSingleProject : Form
    {
        private string id_p;
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=LAPTOP-3UFK0395\\SQLEXPRESS;Initial Catalog=HRD_DB;Integrated Security=True";
        public ShowSingleProject(string id_p)
        {
            this.id_p = id_p;
            InitializeComponent();
        }

        private void ShowSingleProject_Load(object sender, EventArgs e)
        {
            string sql = "SELECT Name, Des, CD, PDS, PDE, FDS, FDE FROM Project WHERE ID_Pr=" + id_p + "";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command = connect.CreateCommand();
            command.CommandText = sql;
            SqlDataReader inv = command.ExecuteReader();
            while (inv.Read())
            {
                NameTextBox.Text = inv["Name"].ToString();
                DescriptionTextBox.Text = inv["Des"].ToString();
                DCreate.Text = Convert.ToDateTime(inv["CD"]).ToShortDateString();
                DPStart.Text = Convert.ToDateTime(inv["PDS"]).ToShortDateString();
                DPEnd.Text = Convert.ToDateTime(inv["PDE"]).ToShortDateString();
                DFStart.Text = Convert.ToDateTime(inv["FDS"]).ToShortDateString();
                DFEnd.Text = Convert.ToDateTime(inv["FDE"]).ToShortDateString();

            }
            sql = "SELECT ID_Emp, LName, Employee.Name as Name, Pat, Post.Name AS PostName, Qualification.Name AS QualName FROM Project INNER JOIN Employee_Project ON Project.ID_Pr = Employee_Project.Pr_ID INNER JOIN Employee ON Employee_Project.Emp_ID = Employee.ID_Emp INNER JOIN Post ON Employee.Po_ID = Post.ID_Po INNER JOIN Qualification ON Employee.Qual_ID = Qualification.ID_Qual WHERE ID_Pr="+id_p+"AND Resp=0";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            command = connect.CreateCommand();
            command.CommandText = sql;
            inv = command.ExecuteReader();
            string[] row = new string[3];
            while (inv.Read())
            {
                dataGridView2.Rows.Add(inv["LName"].ToString(), inv["Name"].ToString(), inv["Pat"].ToString(), inv["PostName"].ToString(), inv["QualName"].ToString());
            }
            connect.Close();

            sql = "SELECT LName FROM Project INNER JOIN Employee_Project ON Project.ID_Pr = Employee_Project.Pr_ID INNER JOIN Employee ON Employee_Project.Emp_ID = Employee.ID_Emp WHERE Resp=1 AND ID_Pr="+id_p;
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            command = connect.CreateCommand();
            command.CommandText = sql;
            string resp = command.ExecuteScalar().ToString();
            RespCombo.Text = resp;
        }
    }
}
