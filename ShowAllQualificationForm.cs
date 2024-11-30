using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRD
{
    public partial class ShowAllQualificationForm : Form
    {
        public ShowAllQualificationForm()
        {
            InitializeComponent();
        }
        private bool addMode = true;
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=LAPTOP-3UFK0395\\SQLEXPRESS;Initial Catalog=HRD_DB;Integrated Security=True";
        private void ShowAllQualificationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Qualification". При необходимости она может быть перемещена или удалена.
            if (this.Tag != null)
            {
            }
        }
        private void addB_Click(object sender, EventArgs e)
        {
            TurnAddMode();
        }
        private void changeB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0) TurnChangeMode();
        }
        private void deleteB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                string id_qual = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "DELETE FROM Qualification WHERE ID_Qual=" + id_qual;
                Sq(sql);
            }
        }
        private void confirmB_Click(object sender, EventArgs e)
        {
            if (addMode)
            {
                string sql = "INSERT INTO Qualification VALUES('" + textBox10.Text + "','" + textBox1.Text + "');";
                Sq(sql);
                if (dataGridView1.RowCount != 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
                    SelectRow(dataGridView1.Rows.Count - 1);
                }
            }
            else
            {
                int n_qual = dataGridView1.CurrentRow.Index;
                string id_qual = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "UPDATE Qualification SET Name ='" + textBox10.Text + "',Coef='" + textBox1.Text + "' WHERE ID_Qual=" + id_qual + ";";
                Sq(sql);
                dataGridView1.CurrentCell = dataGridView1.Rows[n_qual].Cells[1];
                SelectRow(n_qual);
            }
            TurnDefaultMode();
        }
        private void canselB_Click(object sender, EventArgs e)
        {
            TurnDefaultMode();
        }
        public void UpdateQualifiactionTable()
        {
        }
        public void Sq(string sql)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
            connect.Close();
            UpdateQualifiactionTable();
        }
        public void SelectRow(int rowIndex)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Rows[rowIndex].Selected = true;
            dataGridView1.Rows[rowIndex].Cells[0].Selected = true;
        }
        private void TurnDefaultMode()
        {
            showPanel.Visible = true;
            groupBox1.Visible = false;
            addB.Enabled = true;
            changeB.Enabled = true;
            deleteB.Enabled = true;
            confirmB.Visible = false;
            canselB.Visible = false;
            addMode = true;
            TurnClearData();
        }
        private void TurnAddMode()
        {
            showPanel.Visible = false;
            groupBox1.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            addMode = true;
            TurnClearData();
        }
        private void TurnChangeMode()
        {
            showPanel.Visible = false;
            groupBox1.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            addMode = false;
            if (dataGridView1.Rows.Count != 0)
            {
                textBox10.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }
        private void TurnClearData()
        {
            textBox1.Text = string.Empty;
            textBox10.Text = string.Empty;
        }

       
    }
}
