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
    public partial class AddSkillForm : Form
    {
        public string SelectedLevel="1";
        public AddSkillForm()
        {
            InitializeComponent();
        }

        private void confirmB_Click(object sender, EventArgs e)
        {
            SelectedLevel = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void canselB_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public event EventHandler<FormClosedEventArgs> FormClosedWithValue;

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            FormClosedWithValue?.Invoke(this, e);
        }

        private void AddSkillForm_Load(object sender, EventArgs e)
        {

        }
    }
}
