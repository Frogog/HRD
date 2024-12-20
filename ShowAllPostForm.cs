﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRD
{
    public partial class ShowAllPostForm : Form
    {
        public ShowAllPostForm()
        {
            InitializeComponent();
        }
        public string selectedPost = "";
        private bool addMode = true;
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=LAPTOP-3UFK0395\\SQLEXPRESS;Initial Catalog=HRD_DB;Integrated Security=True";
        private void ShowAllPostForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.hRD_DBDataSet.Post);
            //TODO

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
            string id_po = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string sql = "SELECT COUNT(*) FROM Employee WHERE Po_ID = "+ id_po + "; ";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            if (Convert.ToInt32(command.ExecuteScalar().ToString()) == 0)
            {
                if (dataGridView1.RowCount != 0)
                {
                    sql = "DELETE FROM Post WHERE ID_Po=" + id_po;
                    Sq(sql);
                }
            }
            else
            {
                MessageBox.Show("Эта должность связана с записями сотрудников !", "Ошибка",
                    MessageBoxButtons.OK);
            }
        }
        private void canselB_Click(object sender, EventArgs e)
        {
            TurnDefaultMode();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Делать возврат если у формы стоит тег checkPost
            if (this.Tag!=null && this.Tag.ToString() == "checkPost")
            {
                if (e.RowIndex >= 0)
                {
                    selectedPost = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        

        private void confirmB_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (addMode)
            {
                string sql = "INSERT INTO Post VALUES('" + textBox10.Text + "','" + textBox1.Text+"');";
                Sq(sql);
                if (dataGridView1.RowCount != 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
                    SelectRow(dataGridView1.Rows.Count-1);
                }
            }
            else
            {
                int n_po = dataGridView1.CurrentRow.Index;
                string id_po = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "UPDATE Post SET Name ='" + textBox10.Text + "',Pay='"+ textBox1.Text +"' WHERE ID_Po=" + id_po + ";";
                Sq(sql);
                dataGridView1.CurrentCell = dataGridView1.Rows[n_po].Cells[1];
                SelectRow(n_po);
            }
            TurnDefaultMode() ;
        }

        public void UpdatePostTable()
        {
            this.postTableAdapter.Fill(this.hRD_DBDataSet.Post);
        }
        public void Sq(string sql)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
            connect.Close();
            UpdatePostTable();
        }
        public void SelectRow(int rowIndex)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[1];
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
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textBox10.Text))
            {
                MessageBox.Show("Наименование должно быть заполнено!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox10.Focus();
                return false;
            }

            if (!float.TryParse(textBox1.Text, out float pay))
            {
                MessageBox.Show("Зарплата должна быть числом!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return false;
            }

            if (pay <= 0)
            {
                MessageBox.Show("Зарплата должна быть положительным числом!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return false;
            }
            return true;
        }
        
    }
}
