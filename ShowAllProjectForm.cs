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

        private void addB_Click(object sender, EventArgs e)
        {
            showPanel.Visible = false;
            panel1.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
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
        }

        private void addTeamB_Click(object sender, EventArgs e)
        {
            AddTeamForm addTeamForm = new AddTeamForm();
            addTeamForm.ShowDialog();
        }
    }
}
