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
    public partial class ShowAllQualificationForm : Form
    {
        public ShowAllQualificationForm()
        {
            InitializeComponent();
        }

        private void addB_Click(object sender, EventArgs e)
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

        private void GuideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
