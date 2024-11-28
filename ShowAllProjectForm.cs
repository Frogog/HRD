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
    public partial class ShowAllProjectForm : Form
    {
        public ShowAllProjectForm()
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
            panel1.Visible = true;
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
            panel1.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            addMode = false;
        }
        private void deleteB_Click(object sender, EventArgs e)
        {

        }
        private void confirmB_Click(object sender, EventArgs e)
        {
            showPanel.Visible = true;
            panel1.Visible = false;
            addB.Enabled = true;
            changeB.Enabled = true;
            deleteB.Enabled = true;
            confirmB.Visible = false;
            canselB.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            addMode = true;
        }
        private void canselB_Click(object sender, EventArgs e)
        {
            showPanel.Visible = true;
            panel1.Visible = false;
            addB.Enabled = true;
            changeB.Enabled = true;
            deleteB.Enabled = true;
            confirmB.Visible = false;
            canselB.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            addMode = true;
        }

        

        private void showResponsable_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllEmployeeForm>().FirstOrDefault() == null)
            {
                ShowAllEmployeeForm showAllEmployeeForm = new ShowAllEmployeeForm();
                showAllEmployeeForm.Tag = "checkEmployee";
                showAllEmployeeForm.ShowDialog();
            }
        }

        private void ShowAllProjectForm_Load(object sender, EventArgs e)
        {
            dateTimePicker4.Value = DateTime.Now.AddDays(7);
            dateTimePicker3.Value = DateTime.Now.AddDays(7).AddMonths(1);
            dateTimePicker2.Value = DateTime.Now.AddDays(7);
            dateTimePicker1.Value = DateTime.Now.AddDays(7).AddMonths(1);
        }
        private void addTeamB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllEmployeeForm>().FirstOrDefault() == null)
            {
                ShowAllEmployeeForm showAllEmployeeForm = new ShowAllEmployeeForm();
                showAllEmployeeForm.Tag = "checkEmployeeMore";
                showAllEmployeeForm.ShowDialog();
                //Проблему с тем как отличить ответственного от обычного члена команды можно решить если создать класс человека и дать ему свойство.
                //Также можно при создании экземпляра формы дать ему разные конструкторы.
                //Один будет принимать ответственного, а другой обычного сотрудника. Третий можно оставить пустым. Можно подумать над наследованием.
            }
            //AddTeamForm addTeamForm = new AddTeamForm();
            //addTeamForm.ShowDialog();
        }
        private void deleteTeamB_Click(object sender, EventArgs e)
        {

        }
    }
    public class mam
    {

    }
}
