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

namespace HRD
{
    public partial class ShowAllEmployeeForm : Form
    {
        public ShowAllEmployeeForm()
        {
            InitializeComponent();
            this.Size = new Size(861, 770);
        }
        private bool addMode = true;
        private System.Data.SqlClient.SqlConnection connect;
        String connectionString = "Data Source=LAPTOP-3UFK0395\\SQLEXPRESS;Initial Catalog=HRD_DB;Integrated Security=True";
        string id_e = "";
        private void ShowAllEmployeeForm_Load(object sender, EventArgs e)
        {
            //id_e = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //Сделать запрос к бд на данные 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllSkillForm>().FirstOrDefault() != null) MessageBox.Show("Есть скиллы");
            MessageBox.Show(Application.OpenForms.Count.ToString());
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
            addMode = true;
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            showPanel.Visible = false;
            panelAdd.Visible = true;
            addB.Enabled = false;
            changeB.Enabled = false;
            deleteB.Enabled = false;
            confirmB.Visible = true;
            canselB.Visible = true;
            addMode = false;

            //Тут запрос к бд на строку нашего юзера.id возьму из таблицы, на которой фокус.
            //Заполнить все части формы инфой из бд.
            textBox11.Text = "Иванов";
            textBox7.Text = "Иван";
            textBox10.Text = "Иванович";
        }
        private void deleteB_Click(object sender, EventArgs e)
        {
            //Удалить выбранную строку
            UpdaterRows();
        }
        private List<Skill> employeeSkills = new List<Skill>();
        private void addSkillB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllSkillForm>().FirstOrDefault() == null)
            {
                ShowAllSkillForm showAllSkillForm = new ShowAllSkillForm();
                showAllSkillForm.Tag = "checkSkill";
                showAllSkillForm.OnSkillSelected += (skill) => {

                    employeeSkills.Add(skill);

                    UpdateSkillTable();
                };
                showAllSkillForm.ShowDialog();
            }
            //Обновить таблицу со скилами и добавить туда новый. Не забыть подумать над тем как передавать данные между форами.
            //(при выборе скила можно укзать уровень владения и потом уже оба значения в едином объекте возвращать в эту форму. И добавить в список для таблицы).
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
            //Убрать из списка определнный скилл
        }
        

        private void checkPostB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllPostForm>().FirstOrDefault() == null)
            {
                ShowAllPostForm showAllPostForm = new ShowAllPostForm();
                showAllPostForm.Tag = "checkPost";
                showAllPostForm.ShowDialog();
            }
            //Полагаю стоит поставить содержимое поля на выбранный элемент в форме и обновить список в комбобоксе.
        }

        private void checkQualificationB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllQualificationForm>().FirstOrDefault() == null)
            {
                ShowAllQualificationForm showAllQualificationForm = new ShowAllQualificationForm();
                showAllQualificationForm.Tag = "checkPostQualification";
                showAllQualificationForm.ShowDialog();
            }
            //Полагаю стоит поставить содержимое поля на выбранный элемент в форме и обновить список в комбобоксе.

        }
        
        private void confirmB_Click(object sender, EventArgs e)
        {
            if (addMode)
            {
                //Добавить запись в бд
                //Почистить все с вводом
            }
            else
            {
                //Обновить запись в бд по сохраненному id

            }
            //Обновить таблицу и выделить строку, с которой было взаимодействие.
            showPanel.Visible = true;
            panelAdd.Visible = false;
            addB.Enabled = true;
            changeB.Enabled = true;
            deleteB.Enabled = true;
            confirmB.Visible = false;
            canselB.Visible = false;
            addMode = true;

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
            addMode = true;
        }


        

        public void SelectRow()
        {   
            if (dataGridView1.RowCount != 0)
            {
                id_e = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
        }
        public void UpdaterRows()
        {
            /*dataGridView1.Rows.Clear();
            string sql = "SELECT ID_Emp,Qual_ID,Po_ID,Name,LName,Pat,DBirth,PSeries,PNumber,PWho,PWhen,Reg,Res,Email,Tg,Phone FROM Employee WHERE ID_Emp=" + id_e + ";";
            connect = new System.Data.SqlClient.SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = sql;
            SqlDataReader inv = command.ExecuteReader();
            while (inv.Read())
            {
                dataGridView1.Rows.Add(
                    inv["ID_Emp"].ToString(), 
                    inv["Qual_ID"].ToString(), 
                    inv["Po_ID"].ToString(), 
                    inv["Name"].ToString());
                    inv["LName"].ToString();
                    inv["Pat"].ToString();
                    inv["DBirth"].ToString();
                    inv["PSeries"].ToString();
                    inv["PNumber"].ToString();
                    inv["PWho"].ToString();
                    inv["PWhen"].ToString();
                    inv["Reg"].ToString();
                    inv["Res"].ToString();
                    inv["Email"].ToString();
                    inv["Tg"].ToString();
                    inv["Phone"].ToString();
            }
            connect.Close();*/
        }
    }
}
