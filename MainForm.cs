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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllEmployeeForm showAllEmployeeForm = new ShowAllEmployeeForm();
            showAllEmployeeForm.Show();
        }
    }
}