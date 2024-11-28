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
    public partial class ShowAllPostForm : Form
    {
        public ShowAllPostForm()
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
            addMode = true;
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
            //Делать возврат если у формы стоит тег checkPost
            if (e.RowIndex >= 0)
            {
                
            }
        }

        private void ShowAllPostForm_Load(object sender, EventArgs e)
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
            //обновить данные с бд
        }
    }
}
