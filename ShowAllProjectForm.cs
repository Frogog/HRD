using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=LAPTOP-3UFK0395\\SQLEXPRESS;Initial Catalog=HRD_DB;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllSkillForm>().FirstOrDefault() != null) MessageBox.Show("Есть скиллы");
            MessageBox.Show(Application.OpenForms.Count.ToString());
        }

        private void addB_Click(object sender, EventArgs e)
        {
            TurnAddMode();
        }
        private void changeB_Click(object sender, EventArgs e)
        {
            TurnChangeMode();
        }
        private void deleteB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                string id_pr = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "DELETE FROM Project Where ID_Pr = " + id_pr;
                Sq(sql);
            }
        }
        private void confirmB_Click(object sender, EventArgs e)
        {
            if (addMode)
            {
                string sql = "INSERT INTO Project (Name, Des, PDS, PDE, FDS, FDE) VALUES('"
                    + NameTextBox.Text + "','"
                    + DescriptionTextBox.Text + "','"
                    + DPStart.Value.ToString() + "','"
                    + DPEnd.Value.ToString() + "','"
                    + DFStart.Value.ToString() + "','"
                    + DFEnd.Value.ToString() + "');";
                Sq(sql);
            }
            else
            {
                
            }
            TurnDefaultMode();
        }
        private void canselB_Click(object sender, EventArgs e)
        {
            TurnDefaultMode();
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.hRD_DBDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.hRD_DBDataSet.Project);
            DPStart.Value = DateTime.Now.AddDays(7);
            DPEnd.Value = DateTime.Now.AddDays(7).AddMonths(1);
            DFStart.Value = DateTime.Now.AddDays(7);
            DFEnd.Value = DateTime.Now.AddDays(7).AddMonths(1);
        }
        private void addTeamB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllEmployeeForm>().FirstOrDefault() == null)
            {
                ShowAllEmployeeForm showAllEmployeeForm = new ShowAllEmployeeForm();
                showAllEmployeeForm.Tag = "checkTeam";
                DialogResult result = showAllEmployeeForm.ShowDialog();
                if ((result == DialogResult.OK) || (result == DialogResult.Cancel))
                {
                    Employee employee = showAllEmployeeForm.selectedEmployee;
                    if (employee != null)
                    {
                        employeeTeam.Add(employee);
                        UpdateTeamTable();
                    }
                }
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
        public void UpdateEmployeeTable()
        {
            this.projectTableAdapter.Fill(this.hRD_DBDataSet.Project);
        }
        private List<Employee> employeeTeam = new List<Employee>();
        public void DeleteTeamTable() { 

        }
        public void Sq(string sql)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
            connect.Close();
            UpdateEmployeeTable();
        }
        public void SelectRow(int rowIndex)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[0];
            dataGridView1.ClearSelection();
            dataGridView1.Rows[rowIndex].Selected = true;
            dataGridView1.Rows[rowIndex].Cells[0].Selected = true;
        }
        private void TurnDefaultMode()
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
            DFEnd.Visible = false;
            DFStart.Visible = false;
            addMode = true;
            TurnClearData();
        }
        private void TurnAddMode()
        {
            showPanel.Visible = false;
            panel1.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            addMode = true;
            TurnClearData();
        }
        private void TurnChangeMode()
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
            DFEnd.Visible = true;
            DFStart.Visible = true;
            addMode = false;
            if (dataGridView1.Rows.Count != 0)
            {
                NameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                DescriptionTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                DPStart.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                DPEnd.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                DFStart.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                DFEnd.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            }
        }
        private void TurnClearData()
        {
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            DPStart.Value = DateTime.Now.AddDays(7);
            DPEnd.Value = DateTime.Now.AddDays(7).AddMonths(1);
            DFStart.Value = DateTime.Now.AddDays(7);
            DFEnd.Value = DateTime.Now.AddDays(7).AddMonths(1);
            dataGridView2.Rows.Clear();
        }
        private void UpdateTeamTable()
        {
            dataGridView2.Rows.Clear();
            foreach (var employee in employeeTeam)
            {
                dataGridView2.Rows.Add(employee.LName, employee.Name, employee.Pat, employee.PosName, employee.QualName);
            }
        }
    }
}
