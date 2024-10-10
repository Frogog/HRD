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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e) => openFormMenu<ShowAllEmployeeForm>();

        private void PostToolStripMenuItem_Click(object sender, EventArgs e) => openFormMenu<ShowAllPostForm>();

        private void QualificationКвалификацииToolStripMenuItem_Click(object sender, EventArgs e) => openFormMenu<ShowAllQualificationForm>();

        private void ProjectToolStripMenuItem_Click(object sender, EventArgs e) => openFormMenu<ShowAllProjectForm>();

        private void SkillToolStripMenuItem_Click(object sender, EventArgs e) => openFormMenu<ShowAllSkillForm>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllSkillForm>().FirstOrDefault() != null) MessageBox.Show("Есть скиллы");
            MessageBox.Show(Application.OpenForms.Count.ToString());
        }

        private void openFormMenu<T>() where T:Form, new() {
            if (Application.OpenForms.OfType<T>().FirstOrDefault() == null)
            {
                T form = new T();
                form.Show();
            }
        }
    }
}
