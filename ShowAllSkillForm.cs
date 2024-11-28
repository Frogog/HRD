using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private bool addMode = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllSkillForm>().FirstOrDefault() != null) MessageBox.Show("Есть скиллы");
            MessageBox.Show(Application.OpenForms.Count.ToString());
        }
        private void addB_Click(object sender, EventArgs e)
        {
            showPanel.Visible = false;
            groupBox1.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            addMode =true;
        }
        private void changeB_Click(object sender, EventArgs e)
        {
            showPanel.Visible = false;
            groupBox1.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            addMode = false;
        }
        private void deleteB_Click(object sender, EventArgs e)
        {

        }
        private void confirmB_Click(object sender, EventArgs e)
        {
            if (addMode)
            {

            }
            else
            {

            }
            showPanel.Visible = true;
            groupBox1.Visible = false;
            addB.Enabled = true;
            changeB.Enabled = true;
            deleteB.Enabled = true;
            confirmB.Visible = false;
            canselB.Visible = false;
            addMode = true;
        }
        private void canselB_Click(object sender, EventArgs e)
        {
            showPanel.Visible = true;
            groupBox1.Visible = false;
            addB.Enabled = true;
            changeB.Enabled = true;
            deleteB.Enabled = true;
            confirmB.Visible = false;
            canselB.Visible = false;
            addMode = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex >= 0)&&(e.ColumnIndex>=0))
            {
                // Получаем строку, по которой был двойной клик
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Получаем данные из строки
                string value = row.Cells[0].Value.ToString(); // Получаем значение из первой ячейки
                                                              // ... 
                AddSkillForm addSkillForm = new AddSkillForm();
                addSkillForm.ShowDialog();
                // Выполните нужные действия с полученными данными
                // ...
            }
        }

        private void ShowAllSkillForm_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
            }
            dataGridView1.Rows.Add("Владение английским языком");
        }

        
    }
}
