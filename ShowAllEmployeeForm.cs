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
    public partial class ShowAllEmployeeForm : Form
    {
        public ShowAllEmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllSkillForm>().FirstOrDefault() != null) MessageBox.Show("Есть скиллы");
            MessageBox.Show(Application.OpenForms.Count.ToString());
        }

        private void addB_Click(object sender, EventArgs e)
        {
            showPanel.Visible = false;
            panelAdd.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
        }


        private void addB_Click_1(object sender, EventArgs e)
        {
            showPanel.Visible = false;
            panelAdd.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
        }

        private void canselB_Click(object sender, EventArgs e)
        {
            showPanel.Visible = true;
            panelAdd.Visible = false;
            addB.Enabled = true;
            changeB.Enabled = true;
            deleteB.Enabled = true;
            confirmB.Visible = false;
            canselB.Visible = false;
        }

        private void addSkillB_Click(object sender, EventArgs e)
        {
            ShowAllSkillForm showAllSkillForm = new ShowAllSkillForm();
            showAllSkillForm.ShowDialog();
        }

        private void checkPostB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllPostForm>().FirstOrDefault() == null)
            {
                ShowAllPostForm showAllPostForm = new ShowAllPostForm();
                showAllPostForm.Tag = "checkPost";
                showAllPostForm.ShowDialog();
            }
        }

        private void checkQualificationB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllQualificationForm>().FirstOrDefault() == null)
            {
                ShowAllQualificationForm showAllQualificationForm = new ShowAllQualificationForm();
                showAllQualificationForm.Tag = "checkPostQualification";
                showAllQualificationForm.ShowDialog();
            }
           
        }

        private void ShowAllEmployeeForm_Load(object sender, EventArgs e)
        {
        }
    }
}
