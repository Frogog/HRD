﻿using System;
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

        private void addB_Click(object sender, EventArgs e)
        {
            showPanel.Visible = false;
            groupBox1.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
        }

        private void deleteB_Click(object sender, EventArgs e)
        {

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
        }
    }
}
