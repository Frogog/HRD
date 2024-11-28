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
    public partial class ShowAllEmployeeForm : Form
    {
        public ShowAllEmployeeForm()
        {
            InitializeComponent();
        }
        private bool addMode = true;
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

        private void addSkillB_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ShowAllSkillForm>().FirstOrDefault() == null)
            {
                ShowAllSkillForm showAllSkillForm = new ShowAllSkillForm();
                showAllSkillForm.Tag = "checkSkill";
                showAllSkillForm.ShowDialog();
            }
            //Обновить таблицу со скилами и добавить туда новый. Не забыть подумать над тем как передавать данные между форами.
            //(при выборе скила можно укзать уровень владения и потом уже оба значения в едином объекте возвращать в эту форму. И добавить в список для таблицы).
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

        private void ShowAllEmployeeForm_Load(object sender, EventArgs e)
        {
            //Сделать запрос к бд на данные 
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

        private void deleteB_Click(object sender, EventArgs e)
        {
            //Удалить выбранную строку
        }

        private void deleteSkillB_Click(object sender, EventArgs e)
        {
            //Убрать из списка определнный скилл
        }
    }
}
