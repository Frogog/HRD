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
    public partial class ShowAllSkillForm : Form
    {
        public ShowAllSkillForm()
        {
            InitializeComponent();
        }
        public delegate void SkillSelectedHandler(Skill skill);
        public event SkillSelectedHandler OnSkillSelected;
        public delegate void SkillUpdatedHandler(Skill skill);
        public event SkillUpdatedHandler OnSkillUpdated;
        public delegate void SkillDeletedHandler(string skillId);
        public event SkillDeletedHandler OnSkillDeleted;

        private bool addMode = true;
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=LAPTOP-3UFK0395\\SQLEXPRESS;Initial Catalog=HRD_DB;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllSkillForm>().FirstOrDefault() != null) MessageBox.Show("Есть скиллы");
            MessageBox.Show(Application.OpenForms.Count.ToString());
        }
        private void ShowAllSkillForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Skill". При необходимости она может быть перемещена или удалена.
            this.skillTableAdapter.Fill(this.hRD_DBDataSet.Skill);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Skill". При необходимости она может быть перемещена или удалена.
            //dataGridView1.Rows.Add("Владение английским языком");
        }
        private void addB_Click(object sender, EventArgs e)
        {
            TurnAddMode();
        }
        private void changeB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count!=0) TurnChangeMode();
        }
        private void deleteB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                string id_skill = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "DELETE FROM Skill WHERE ID_Skill=" + id_skill;
                Sq(sql);
                OnSkillDeleted.Invoke(id_skill);
            }
        }
        private void confirmB_Click(object sender, EventArgs e)
        {
            if (addMode)
            {
                string sql = "INSERT INTO Skill VALUES('" + textBox10.Text + "');";
                Sq(sql);
                if (dataGridView1.RowCount != 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1];
                    SelectRow(dataGridView1.Rows.Count - 1);
                }
            }
            else
            {
                int n_skill = dataGridView1.CurrentRow.Index;
                string id_skill = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "UPDATE Skill SET Name ='" + textBox10.Text + "' WHERE ID_Skill=" + id_skill + ";";
                Sq(sql);
                dataGridView1.CurrentCell = dataGridView1.Rows[n_skill].Cells[1];
                SelectRow(n_skill);
                OnSkillUpdated.Invoke(new Skill(id_skill, dataGridView1.CurrentRow.Cells[1].Value.ToString(), ""));
            }
            TurnDefaultMode();
        }
        private void canselB_Click(object sender, EventArgs e)
        {
            TurnDefaultMode();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Tag !=null)
            {
                if ((e.RowIndex >= 0) && (e.ColumnIndex >= 0))
                {
                    // Получаем строку, по которой был двойной клик
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string skillId = row.Cells[0].Value.ToString();
                    string skillName = row.Cells[1].Value.ToString();

                    // Получаем данные из строки
                    string value = row.Cells[0].Value.ToString(); // Получаем значение из первой ячейки
                                                                  // ... 
                    AddSkillForm addSkillForm = new AddSkillForm();
                    if (addSkillForm.ShowDialog() == DialogResult.OK)
                    {
                        string skillLevel = addSkillForm.SelectedLevel; // Предполагаем, что в AddSkillForm есть такое свойство

                        // Вызываем событие с передачей всех данных
                        OnSkillSelected?.Invoke(new Skill(skillId, skillName, skillLevel));
                        this.Close();
                    }
                    // Выполните нужные действия с полученными данными
                    // ...
                }
            }
            
        }
        public void UpdatePostTable()
        {
            this.skillTableAdapter.Fill(this.hRD_DBDataSet.Skill);
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
            dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[0];
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
            }
        }
        private void TurnClearData()
        {
            textBox10.Text = string.Empty;
        }

    }
}
