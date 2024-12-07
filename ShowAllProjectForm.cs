using Spire.Doc.Fields.Shapes;
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
        private List<EmployeeTeam> employeeTeam = new List<EmployeeTeam>();

        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=LAPTOP-3UFK0395\\SQLEXPRESS;Initial Catalog=HRD_DB;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllSkillForm>().FirstOrDefault() != null) MessageBox.Show("Есть скиллы");
            MessageBox.Show(Application.OpenForms.Count.ToString());
        }
        private void ShowAllProjectForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.hRD_DBDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.hRD_DBDataSet.Project);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hRD_DBDataSet.Project". При необходимости она может быть перемещена или удалена.
        }
        private void addB_Click(object sender, EventArgs e)
        {
            TurnAddMode();
        }
        private void changeB_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0) TurnChangeMode();
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
            if (!ValidateProjectForm()) return;
            if (addMode)
            {
                string sql = "INSERT INTO Project (Name, CD, Des, PDS, PDE, FDS, FDE) VALUES('"
                    + NameTextBox.Text + "','"
                    + DCreate.Value.ToString()+ "','"
                    + DescriptionTextBox.Text + "','"
                    + DPStart.Value.ToString() + "','"
                    + DPEnd.Value.ToString() + "',NULL,NULL);";
                Sq(sql);
                string id_p = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value.ToString();
                sql = "INSERT INTO Employee_Project (Emp_ID, Pr_ID, Resp) VALUES('" +
                        RespCombo.SelectedValue + "','" +
                        id_p + "','1')";
                Sq(sql);
                foreach (var employee in employeeTeam)
                {
                    sql = "INSERT INTO Employee_Project (Emp_ID, Pr_ID, Resp) VALUES('" +
                        employee.ID_Emp + "','" +
                        id_p + "','0')";
                    Sq(sql);
                }
                SelectRow(dataGridView1.Rows.Count - 1);
            }
            else
            {
                int n_p = dataGridView1.CurrentRow.Index;
                string id_p = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "UPDATE Project SET "
                + "Name ='" + NameTextBox.Text
                + "', Des ='" + DescriptionTextBox.Text
                + "', CD ='" + DCreate.Value.ToString()
                + "', PDS ='" + DPStart.Value.ToString()
                + "', PDE ='" + DPEnd.Value.ToString()
                + "', FDS ='" + DFStart.Value.ToString()
                + "', FDE ='" + DFEnd.Value.ToString() +"' WHERE ID_Pr="+id_p+";";
                Sq(sql);
                sql = "DELETE FROM Employee_Project WHERE Pr_ID = " + id_p + ";";
                Sq(sql);
                sql = "INSERT INTO Employee_Project (Emp_ID, Pr_ID, Resp) VALUES('" +
                        RespCombo.SelectedValue + "','" +
                        id_p + "','1')";
                Sq(sql);
                foreach (var employee in employeeTeam)
                {
                    sql = "INSERT INTO Employee_Project (Emp_ID,Pr_ID, Resp) VALUES('" +
                        employee.ID_Emp + "','" +
                        id_p + "','0')";
                    Sq(sql);
                }
                SelectRow(n_p);
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
                showAllEmployeeForm.Tag = "checkResponsable";
                showAllEmployeeForm.OnEmployeeSelected += (employeeSelected) =>
                {
                    var existingEmployee = employeeTeam.FirstOrDefault(x => x.ID_Emp == employeeSelected.ID_Emp);
                    if (existingEmployee != null)
                    {
                        var index = employeeTeam.IndexOf(existingEmployee);
                        employeeTeam[index] = employeeSelected;

                    }
                    else
                    {
                        employeeTeam.Add(employeeSelected);
                    }
                };
                showAllEmployeeForm.OnEmployeeUpdated += (updatedEmployee) =>
                {
                    var existingEmployee = employeeTeam.FirstOrDefault(x => x.ID_Emp == updatedEmployee.ID_Emp);
                    if (existingEmployee != null)
                    {
                        var index = employeeTeam.IndexOf(existingEmployee);
                        employeeTeam[index] = updatedEmployee;
                    }
                };
                showAllEmployeeForm.OnEmployeeDeleted += (employeeId) =>
                {
                    employeeTeam.RemoveAll(x => x.ID_Emp == employeeId);
                };
                showAllEmployeeForm.OnResponsableSelected += (responsableId) =>
                {
                    employeeTeam.RemoveAll(x => x.ID_Emp == responsableId);
                };
                DialogResult result = showAllEmployeeForm.ShowDialog();
                if ((result == DialogResult.OK) || (result == DialogResult.Cancel))
                {
                    string responsable = showAllEmployeeForm.selectedResponsable;
                    this.employeeTableAdapter.Fill(this.hRD_DBDataSet.Employee);
                    if (responsable != "") RespCombo.SelectedValue = responsable;
                }
                UpdateTeamTable();
            }
        }

        
        private void addTeamB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllEmployeeForm>().FirstOrDefault() == null)
            {
                ShowAllEmployeeForm showAllEmployeeForm = new ShowAllEmployeeForm();
                showAllEmployeeForm.Tag = "checkTeam";
                showAllEmployeeForm.OnEmployeeSelected += (employeeSelected) =>
                {
                    if (employeeSelected.ID_Emp != RespCombo.SelectedValue.ToString())
                    {
                        var existingEmployee = employeeTeam.FirstOrDefault(x => x.ID_Emp == employeeSelected.ID_Emp);
                        if (existingEmployee != null)
                        {
                            var index = employeeTeam.IndexOf(existingEmployee);
                            employeeTeam[index] = employeeSelected;

                        }
                        else
                        {
                            employeeTeam.Add(employeeSelected);
                        }
                        showAllEmployeeForm.DialogResult = DialogResult.OK;
                        showAllEmployeeForm.Close();
                    }
                    else
                    {
                        ShowError("Ответственный не может быть в команде!", RespCombo);
                    }
                };
                showAllEmployeeForm.OnEmployeeUpdated += (updatedEmployee) =>
                {
                    var existingEmployee = employeeTeam.FirstOrDefault(x => x.ID_Emp == updatedEmployee.ID_Emp);
                    if (existingEmployee != null)
                    {
                        var index = employeeTeam.IndexOf(existingEmployee);
                        employeeTeam[index] = updatedEmployee;
                    }
                };
                showAllEmployeeForm.OnEmployeeDeleted += (employeeId) =>
                {
                    employeeTeam.RemoveAll(x => x.ID_Emp == employeeId);
                };
                showAllEmployeeForm.ShowDialog();
                UpdateTeamTable();
                var rememberValue = RespCombo.SelectedValue;
                this.employeeTableAdapter.Fill(this.hRD_DBDataSet.Employee);
                RespCombo.SelectedValue = rememberValue;
            }
        }
        private void deleteTeamB_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                employeeTeam.RemoveAt(dataGridView2.CurrentRow.Index);
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
        }
        public void UpdateProjectTable()
        {
            this.projectTableAdapter.Fill(this.hRD_DBDataSet.Project);
        }
        public void Sq(string sql)
        {
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
            connect.Close();
            UpdateProjectTable();
        }
        public void SelectRow(int rowIndex)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[1];
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
            moreB.Enabled = true;
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
            moreB.Enabled = false;
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
            moreB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            DFEnd.Visible = true;
            DFStart.Visible = true;
            addMode = false;
            NameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DescriptionTextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DCreate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            DPStart.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            DPEnd.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            if (dataGridView1.CurrentRow.Cells[6].Value.ToString() != "")
            {
                DFStart.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            }
            else DFStart.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            if (dataGridView1.CurrentRow.Cells[7].Value.ToString() != "")
            {
                DFEnd.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            }
            else DFEnd.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            string sql = "SELECT Emp_ID FROM Employee_Project WHERE Pr_ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
                "AND Resp = 1;";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            string id_e = command.ExecuteScalar().ToString();
            RespCombo.SelectedValue = id_e;
            connect.Close();
            sql = "SELECT Emp_ID, LName, Employee.Name AS EmployeeName, Pat, Post.Name AS PostName, Qualification.Name AS QualificationName, Resp FROM Employee INNER JOIN Employee_Project ON Employee.ID_Emp = Employee_Project.Emp_ID INNER JOIN Qualification ON Employee.Qual_ID = Qualification.ID_Qual INNER JOIN Post ON Employee.Po_ID = Post.ID_Po WHERE Resp = 0 AND Pr_ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            command = connect.CreateCommand();
            command.CommandText = sql;
            SqlDataReader inv = command.ExecuteReader();
            string[] row = new string[5];
            while (inv.Read())
            {
                employeeTeam.Add(new EmployeeTeam(
                    inv["Emp_ID"].ToString(),
                    inv["LName"].ToString(),
                    inv["EmployeeName"].ToString(),
                    inv["Pat"].ToString(),
                    inv["PostName"].ToString(),
                    inv["QualificationName"].ToString()
                    ));
                row[0] = inv["LName"].ToString();
                row[1] = inv["EmployeeName"].ToString();
                row[2] = inv["Pat"].ToString();
                row[3] = inv["PostName"].ToString();
                row[4] = inv["QualificationName"].ToString();
                dataGridView2.Rows.Add(row);
            }
            connect.Close();
        }
        private void TurnClearData()
        {
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
            DCreate.Value = DateTime.Now;
            DPStart.Value = DateTime.Now.AddDays(7);
            DPEnd.Value = DateTime.Now.AddDays(7).AddMonths(1);
            DFStart.Value = DateTime.Now.AddDays(7);
            DFEnd.Value = DateTime.Now.AddDays(7).AddMonths(1);
            dataGridView2.Rows.Clear();
            employeeTeam.Clear();
        }
        private void UpdateTeamTable()
        {
            dataGridView2.Rows.Clear();
            foreach (var employee in employeeTeam)
            {
                dataGridView2.Rows.Add(employee.LName, employee.Name, employee.Pat, employee.PosName, employee.QualName);
            }
        }

        private void RespCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (RespCombo.SelectedValue != null)
            {
                employeeTeam.RemoveAll(x => x.ID_Emp == RespCombo.SelectedValue.ToString());
                UpdateTeamTable();
            }
        }
        private bool ValidateProjectForm()
        {
            // Проверка обязательных полей
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                ShowError("Название проекта должно быть заполнено!", NameTextBox);
                return false;
            }

            if (string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
            {
                ShowError("Описание проекта должно быть заполнено!", DescriptionTextBox);
                return false;
            }

            // Проверка корректности дат
            DateTime currentDate = DateTime.Now.Date;

            // Дата создания не может быть в будущем
            if (DCreate.Value.Date > currentDate)
            {
                ShowError("Дата создания не может быть в будущем!", DCreate);
                return false;
            }
            if (DCreate.Value.Date < currentDate)
            {
                ShowError("Дата создания не может быть в прошлом!", DCreate);
                return false;
            }

            // Проверка планируемых дат
            if (DPStart.Value.Date > DPEnd.Value.Date)
            {
                ShowError("Планируемая дата начала не может быть позже даты окончания!", DPStart);
                return false;
            }

            if (DPStart.Value.Date < DCreate.Value.Date)
            {
                ShowError("Планируемая дата начала не может быть раньше даты создания проекта!", DPStart);
                return false;
            }

            // Проверка фактических дат
            if (!addMode) {
                if (DFStart.Value.Date > DFEnd.Value.Date)
                {
                    ShowError("Фактическая дата начала не может быть позже даты окончания!", DFStart);
                    return false;
                }

                if (DFStart.Value.Date < DCreate.Value.Date)
                {
                    ShowError("Фактическая дата начала не может быть раньше даты создания проекта!", DFStart);
                    return false;
                }

                // Дополнительные проверки логики дат
                if (DFStart.Value.Date < DPStart.Value.Date)
                {
                    ShowError("Фактическая дата начала не может быть раньше планируемой!", DFStart);
                    return false;
                }

                if (DFEnd.Value.Date < DPStart.Value.Date)
                {
                    ShowError("Фактическая дата окончания не может быть раньше планируемой даты начала!", DFEnd);
                    return false;
                }
            }
            

            return true;
        }
        private void ShowError(string message, Control control)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            control.Focus();
        }

        private void moreB_Click(object sender, EventArgs e)
        {
            ShowSecondSingleProject showSingleProject = new ShowSecondSingleProject(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            showSingleProject.ShowDialog();
        }
    }
}
