﻿using Spire.Doc.Fields;
using Spire.Doc.Fields.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HRD
{
    public partial class ShowAllEmployeeForm : Form
    {
        public delegate void EmployeeSelectedHandler(Employee employee);
        public event EmployeeSelectedHandler OnEmployeeSelected;
        public delegate void EmployeeUpdatedHandler(Employee employee);
        public event EmployeeUpdatedHandler OnEmployeeUpdated;
        public delegate void EmployeeDeletedHandler(string employeeId);
        public event EmployeeDeletedHandler OnEmployeeDeleted;
        public ShowAllEmployeeForm()
        {
            InitializeComponent();
            this.Size = new Size(861, 770);
        }
        private bool addMode = true;
        private List<Skill> employeeSkills = new List<Skill>();
        public Employee selectedEmployee = null; //Бесполезно. Лучше бурать
        public string selectedResponsable = "";
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=LAPTOP-3UFK0395\\SQLEXPRESS;Initial Catalog=HRD_DB;Integrated Security=True";
        string id_e = "";
        private void ShowAllEmployeeForm_Load(object sender, EventArgs e)
        {
            
        }
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
                string id_e = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                OnEmployeeDeleted(id_e);
                string sql = "DELETE FROM Employee WHERE ID_Emp=" + id_e;
                Sq(sql);
            }
        }

        private void addSkillB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllSkillForm>().FirstOrDefault() == null)
            {
                ShowAllSkillForm showAllSkillForm = new ShowAllSkillForm();
                showAllSkillForm.Tag = "checkSkill";
                showAllSkillForm.OnSkillSelected += (skill) => {
                    var existingSkill = employeeSkills.FirstOrDefault(x => x.skillId == skill.skillId);
                    if (existingSkill != null)
                    {
                        var index = employeeSkills.IndexOf(existingSkill);
                        employeeSkills[index] = skill;
                    }
                    else
                    {
                        employeeSkills.Add(skill);
                    }
                };
                showAllSkillForm.OnSkillUpdated += (skill) =>
                {
                    var existingSkill = employeeSkills.FirstOrDefault(x => x.skillId == skill.skillId);
                    if (existingSkill != null)
                    {
                        existingSkill.skillName = skill.skillName;
                    }
                };
                showAllSkillForm.OnSkillDeleted += (skillId) =>
                {
                    employeeSkills.RemoveAll(x => x.skillId == skillId);
                };
                showAllSkillForm.ShowDialog();
                //employeeSkills = employeeSkills.Where(existingSkill => !showAllSkillForm.deletedSkills.Contains(existingSkill)).ToList();
                UpdateSkillTable();
            }
        }
        private void UpdateSkillTable()
        {

            dataGridView2.Rows.Clear();

            foreach (var skill in employeeSkills)
            {
                dataGridView2.Rows.Add(skill.skillId, skill.skillName, skill.skillLevel);
            }
        }
        private void deleteSkillB_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                employeeSkills.RemoveAt(dataGridView2.CurrentRow.Index);
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
        }
        

        private void checkPostB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllPostForm>().FirstOrDefault() == null)
            {
                ShowAllPostForm showAllPostForm = new ShowAllPostForm();
                showAllPostForm.Tag = "checkPost";
                DialogResult result = showAllPostForm.ShowDialog();
                if ((result == DialogResult.OK) || (result == DialogResult.Cancel))
                {
                    string post = showAllPostForm.selectedPost;
                    //TODO
                    if(post!="") PostCombo.SelectedValue = post;
                }
            }
        }

        private void checkQualificationB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllQualificationForm>().FirstOrDefault() == null)
            {
                ShowAllQualificationForm showAllQualificationForm = new ShowAllQualificationForm();
                showAllQualificationForm.Tag = "checkQual";
                DialogResult result = showAllQualificationForm.ShowDialog();
                if ((result == DialogResult.OK) || (result == DialogResult.Cancel))
                {
                    string qual = showAllQualificationForm.selectedQual;
                    //TODO
                    if (qual!="") QualCombo.SelectedValue = qual;
                }
            }
            //Полагаю стоит поставить содержимое поля на выбранный элемент в форме и обновить список в комбобоксе.

        }
        
        private void confirmB_Click(object sender, EventArgs e)
        {
            if (addMode)
            {
                string sql = "INSERT INTO Employee (Qual_ID, Po_ID, Name, LName, Pat, " +
               "DBirth, PSeries, PNumber, PWho, PWhen, " +
               "Reg, Res, Email, Tg, Phone) VALUES('" +
                    QualCombo.SelectedValue + "','" +
                    PostCombo.SelectedValue + "','" +
                    NameTextBox.Text + "','" +
                    LNameTextBox.Text + "','" +
                    PatTextBox.Text + "','" +
                    BirthDate.Value.ToString() + "','" +
                    PSeriesTextBox.Text + "','" +
                    PNumberTextBox.Text + "','" +
                    WhoTextBox.Text + "','" +
                    WhenDate.Value.ToString() + "','" +
                    RegTextBox.Text + "','" +
                    ResTextBox.Text + "','" +
                    EmailTextBox.Text + "','" +
                    TgTextBox.Text + "','" +
                    PhoneTextBox.Text + "')";
                Sq(sql);
                string id_e = dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0].Value.ToString();
                foreach (var skill in employeeSkills)
                {
                    sql = "INSERT INTO Employee_Skill (Emp_ID, Skill_ID, Prof) VALUES('" +
                        id_e + "','" +
                        skill.skillId + "','" +
                        skill.skillLevel + "')";
                    Sq(sql);
                }
                SelectRow(dataGridView1.Rows.Count - 1);
            }
            else
            {
                int n_e = dataGridView1.CurrentRow.Index;
                string id_e = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string sql = "UPDATE Employee SET "
                +"Qual_ID ='" + QualCombo.SelectedValue
                + "', Po_ID ='" + PostCombo.SelectedValue
                + "', Name ='" + NameTextBox.Text
                + "', LName ='" + LNameTextBox.Text
                + "', Pat ='" + PatTextBox.Text
                + "', DBirth ='" + BirthDate.Value.ToString()
                + "', PSeries ='" + PSeriesTextBox.Text
                + "', PNumber ='" + PNumberTextBox.Text
                + "', PWho ='" + WhoTextBox.Text
                + "', PWhen ='" + WhenDate.Value.ToString()
                + "', Reg ='" + RegTextBox.Text
                + "', Res ='" + ResTextBox.Text
                + "', Email ='" + EmailTextBox.Text
                + "', Tg ='" + TgTextBox.Text
                + "', Phone ='" + PhoneTextBox.Text
                + "' WHERE ID_Emp=" + id_e + ";";
                if (OnEmployeeUpdated != null)
                {
                    OnEmployeeUpdated.Invoke(new Employee(
                    id_e,
                    QualCombo.SelectedValue.ToString(),
                    PostCombo.SelectedValue.ToString(),
                    NameTextBox.Text,
                    LNameTextBox.Text,
                    DateTime.Parse(BirthDate.Value.ToString()),
                    PSeriesTextBox.Text,
                    PNumberTextBox.Text,
                    WhoTextBox.Text,
                    DateTime.Parse(WhenDate.Value.ToString()),
                    RegTextBox.Text,
                    ResTextBox.Text,
                    PhoneTextBox.Text,
                    PostCombo.Text,
                    QualCombo.Text
                    ));
                }
                Sq(sql);
                sql = "DELETE FROM Employee_Skill WHERE Emp_ID = " + id_e + ";";
                Sq(sql);
                foreach (var skill in employeeSkills)
                {
                    sql = "INSERT INTO Employee_Skill (Emp_ID, Skill_ID, Prof) VALUES('" +
                        id_e + "','" +
                        skill.skillId + "','" +
                        skill.skillLevel + "')";
                    Sq(sql);
                }
                SelectRow(n_e);
            }
            TurnDefaultMode();
        }
        private void canselB_Click(object sender, EventArgs e)
        {
            TurnDefaultMode();
        }

        public void UpdateEmployeeTable()
        {
            //TODO
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
            panelAdd.Visible = false;
            addB.Enabled = true;
            changeB.Enabled = true;
            deleteB.Enabled = true;
            confirmB.Visible = false;
            canselB.Visible = false;
            addMode = true;
            TurnClearData();
        }
        private void TurnAddMode()
        {
            showPanel.Visible = false;
            panelAdd.Visible = true;
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
            panelAdd.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            addMode = false;
            if (dataGridView1.Rows.Count != 0)
            {
                NameTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                LNameTextBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                PatTextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                PSeriesTextBox.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                PNumberTextBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                WhoTextBox.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                RegTextBox.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                ResTextBox.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                PostCombo.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                QualCombo.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                BirthDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                WhenDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[10].Value.ToString());
                EmailTextBox.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                TgTextBox.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                PhoneTextBox.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            }
            string sql = "SELECT Skill_ID, Name, Prof FROM Skill INNER JOIN Employee_Skill ON ID_Skill = Skill_ID WHERE Emp_ID=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ";";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            SqlDataReader inv = command.ExecuteReader();
            string[] row = new string[3];
            while (inv.Read())
            {
                employeeSkills.Add(new Skill(inv["Skill_ID"].ToString(), inv["Name"].ToString(), inv["Prof"].ToString()));
                row[0] = inv["Skill_ID"].ToString();
                row[1] = inv["Name"].ToString();
                row[2] = inv["Prof"].ToString();
                dataGridView2.Rows.Add(row);
            }
            connect.Close();
        }
        private void TurnClearData()
        {
            NameTextBox.Text = string.Empty;
            LNameTextBox.Text = string.Empty;
            PatTextBox.Text = string.Empty;
            PSeriesTextBox.Text = string.Empty;
            PNumberTextBox.Text = string.Empty;
            WhoTextBox.Text = string.Empty;
            WhoTextBox.Text = string.Empty;
            RegTextBox.Text = string.Empty;
            ResTextBox.Text = string.Empty;
            //TODO
            //TODO
            dataGridView2.Rows.Clear();
            employeeSkills.Clear();
            EmailTextBox.Text = "";
            TgTextBox.Text = "";
            PhoneTextBox.Text = "";
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddSkillForm addSkillForm = new AddSkillForm(employeeSkills[dataGridView2.CurrentRow.Index].skillLevel);
            if (addSkillForm.ShowDialog() == DialogResult.OK)
            {
                string id_e = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                int n_s = dataGridView2.CurrentRow.Index;
                string skillLevel = addSkillForm.SelectedLevel;
                employeeSkills[dataGridView2.CurrentRow.Index].skillLevel = skillLevel;
                string sql = "UPDATE Employee_Skill SET "
               + "Prof ='" + skillLevel
               + "' WHERE Emp_ID=" + id_e + ", "
               + "Skill_ID =" + employeeSkills[dataGridView2.CurrentRow.Index].skillId + ";";
                UpdateSkillTable();
                dataGridView2.CurrentCell = dataGridView2.Rows[n_s].Cells[0];
                dataGridView2.ClearSelection();
                dataGridView2.Rows[n_s].Selected = true;
                dataGridView2.Rows[n_s].Cells[0].Selected = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Tag != null)
            {
                if (this.Tag.ToString() == "checkTeam")
                {
                    selectedEmployee = new Employee(
                        dataGridView1.CurrentRow.Cells[0].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[2].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                        DateTime.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString()),
                        dataGridView1.CurrentRow.Cells[7].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[9].Value.ToString(),
                        DateTime.Parse(dataGridView1.CurrentRow.Cells[10].Value.ToString()),
                        dataGridView1.CurrentRow.Cells[11].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[12].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[15].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[5].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[13].Value.ToString(),
                        dataGridView1.CurrentRow.Cells[14].Value.ToString(),
                        "Временная должность",
                        "Временная квала"
                        );
                    OnEmployeeSelected.Invoke(selectedEmployee);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                if (this.Tag.ToString()== "checkResponsable")
                {
                    selectedResponsable = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
