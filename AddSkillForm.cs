using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRD
{
    public partial class AddSkillForm : Form
    {
        public string SelectedLevel="0";
        public AddSkillForm(string selectedLevel = "0")
        {
            this.SelectedLevel = selectedLevel;
            InitializeComponent();
        }

        private void confirmB_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
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
            textBox1.Text = SelectedLevel;
        }
        private bool ValidateForm()
        {
            if (!int.TryParse(textBox1.Text, out int skill))
            {
                MessageBox.Show("Уровень владения навыком должен быть целым числом!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return false;
            }
            if ((skill < 0)||(skill > 10))
            {
                MessageBox.Show("Уровень владения навыком должен быть в пределах от 0 до 10!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return false;
            }
            return true;
        }
    }
}
