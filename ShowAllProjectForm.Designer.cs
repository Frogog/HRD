﻿namespace HRD
{
    partial class ShowAllProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deleteTeamB = new System.Windows.Forms.Button();
            this.addTeamB = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.canselB = new System.Windows.Forms.Button();
            this.deleteB = new System.Windows.Forms.Button();
            this.changeB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            this.confirmB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanDateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainLable = new System.Windows.Forms.Label();
            this.showPanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showResponsable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.showPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteTeamB
            // 
            this.deleteTeamB.Location = new System.Drawing.Point(1260, 140);
            this.deleteTeamB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteTeamB.Name = "deleteTeamB";
            this.deleteTeamB.Size = new System.Drawing.Size(33, 28);
            this.deleteTeamB.TabIndex = 29;
            this.deleteTeamB.Text = "-";
            this.deleteTeamB.UseVisualStyleBackColor = true;
            // 
            // addTeamB
            // 
            this.addTeamB.Location = new System.Drawing.Point(1260, 105);
            this.addTeamB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addTeamB.Name = "addTeamB";
            this.addTeamB.Size = new System.Drawing.Size(33, 28);
            this.addTeamB.TabIndex = 28;
            this.addTeamB.Text = "+";
            this.addTeamB.UseVisualStyleBackColor = true;
            this.addTeamB.Click += new System.EventHandler(this.addTeamB_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Команда";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.Patronymic,
            this.Post,
            this.Qualification});
            this.dataGridView2.Location = new System.Drawing.Point(8, 105);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1244, 276);
            this.dataGridView2.TabIndex = 14;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 150;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 150;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.MinimumWidth = 6;
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.ReadOnly = true;
            this.Patronymic.Width = 150;
            // 
            // Post
            // 
            this.Post.HeaderText = "Должность";
            this.Post.MinimumWidth = 6;
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            this.Post.Width = 250;
            // 
            // Qualification
            // 
            this.Qualification.HeaderText = "Уровень";
            this.Qualification.MinimumWidth = 6;
            this.Qualification.Name = "Qualification";
            this.Qualification.ReadOnly = true;
            this.Qualification.Width = 150;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 43);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(404, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ответственный";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(381, 43);
            this.dateTimePicker5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата создания";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(205, 264);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "План.  дата завершения";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(12, 264);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "План. дата начала";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // canselB
            // 
            this.canselB.Location = new System.Drawing.Point(1195, 766);
            this.canselB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.canselB.Name = "canselB";
            this.canselB.Size = new System.Drawing.Size(133, 28);
            this.canselB.TabIndex = 26;
            this.canselB.Text = "Отмена";
            this.canselB.UseVisualStyleBackColor = true;
            this.canselB.Visible = false;
            this.canselB.Click += new System.EventHandler(this.canselB_Click);
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(1336, 142);
            this.deleteB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(133, 28);
            this.deleteB.TabIndex = 25;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = true;
            // 
            // changeB
            // 
            this.changeB.Location = new System.Drawing.Point(1336, 70);
            this.changeB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(133, 28);
            this.changeB.TabIndex = 24;
            this.changeB.Text = "Редактировать";
            this.changeB.UseVisualStyleBackColor = true;
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(1336, 34);
            this.addB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(133, 28);
            this.addB.TabIndex = 23;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // confirmB
            // 
            this.confirmB.Location = new System.Drawing.Point(1053, 766);
            this.confirmB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(133, 28);
            this.confirmB.TabIndex = 27;
            this.confirmB.Text = "ОК";
            this.confirmB.UseVisualStyleBackColor = true;
            this.confirmB.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProject,
            this.Description,
            this.CreateDate,
            this.FactStartDate,
            this.FactEndDate,
            this.PlanStartDate,
            this.PlanDateEnd,
            this.Responsable});
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1304, 722);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameProject
            // 
            this.NameProject.HeaderText = "Наименование";
            this.NameProject.MinimumWidth = 6;
            this.NameProject.Name = "NameProject";
            this.NameProject.ReadOnly = true;
            this.NameProject.Width = 200;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 200;
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "Дата создания";
            this.CreateDate.MinimumWidth = 6;
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.ReadOnly = true;
            this.CreateDate.Width = 75;
            // 
            // FactStartDate
            // 
            this.FactStartDate.HeaderText = "Факт. дата начала";
            this.FactStartDate.MinimumWidth = 6;
            this.FactStartDate.Name = "FactStartDate";
            this.FactStartDate.ReadOnly = true;
            this.FactStartDate.Width = 90;
            // 
            // FactEndDate
            // 
            this.FactEndDate.HeaderText = "Факт. дата завершения";
            this.FactEndDate.MinimumWidth = 6;
            this.FactEndDate.Name = "FactEndDate";
            this.FactEndDate.ReadOnly = true;
            this.FactEndDate.Width = 90;
            // 
            // PlanStartDate
            // 
            this.PlanStartDate.HeaderText = "План. дата начала";
            this.PlanStartDate.MinimumWidth = 6;
            this.PlanStartDate.Name = "PlanStartDate";
            this.PlanStartDate.ReadOnly = true;
            this.PlanStartDate.Width = 90;
            // 
            // PlanDateEnd
            // 
            this.PlanDateEnd.HeaderText = "План. дата завершения";
            this.PlanDateEnd.MinimumWidth = 6;
            this.PlanDateEnd.Name = "PlanDateEnd";
            this.PlanDateEnd.ReadOnly = true;
            this.PlanDateEnd.Width = 90;
            // 
            // Responsable
            // 
            this.Responsable.HeaderText = "Ответственный";
            this.Responsable.MinimumWidth = 6;
            this.Responsable.Name = "Responsable";
            this.Responsable.ReadOnly = true;
            this.Responsable.Width = 205;
            // 
            // mainLable
            // 
            this.mainLable.AutoSize = true;
            this.mainLable.Location = new System.Drawing.Point(15, 11);
            this.mainLable.Name = "mainLable";
            this.mainLable.Size = new System.Drawing.Size(152, 16);
            this.mainLable.TabIndex = 3;
            this.mainLable.Text = "Справочник проектов";
            // 
            // showPanel
            // 
            this.showPanel.Controls.Add(this.dataGridView1);
            this.showPanel.Location = new System.Drawing.Point(19, 34);
            this.showPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(1309, 727);
            this.showPanel.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 102);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1283, 122);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker5);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker4);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1301, 311);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общие данные";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Описание";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(19, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 727);
            this.panel1.TabIndex = 32;
            this.panel1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showResponsable);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.addTeamB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.deleteTeamB);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(4, 322);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1301, 401);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Формирование команды";
            // 
            // showResponsable
            // 
            this.showResponsable.Location = new System.Drawing.Point(423, 41);
            this.showResponsable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showResponsable.Name = "showResponsable";
            this.showResponsable.Size = new System.Drawing.Size(33, 28);
            this.showResponsable.TabIndex = 33;
            this.showResponsable.Text = "...";
            this.showResponsable.UseVisualStyleBackColor = true;
            this.showResponsable.Click += new System.EventHandler(this.showResponsable_Click);
            // 
            // ShowAllProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 802);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainLable);
            this.Controls.Add(this.canselB);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.changeB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.confirmB);
            this.Controls.Add(this.showPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShowAllProjectForm";
            this.Text = "Проекты";
            this.Load += new System.EventHandler(this.ShowAllProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.showPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button canselB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button changeB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label mainLable;
        private System.Windows.Forms.Panel showPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button deleteTeamB;
        private System.Windows.Forms.Button addTeamB;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button showResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanDateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsable;
    }
}