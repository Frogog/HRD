namespace HRD
{
    partial class ShowSecondSingleProject
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
            this.mainLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DCreate2 = new System.Windows.Forms.Label();
            this.DPStart = new System.Windows.Forms.Label();
            this.DFEnd = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.Label();
            this.DFStart = new System.Windows.Forms.Label();
            this.DPEnd = new System.Windows.Forms.Label();
            this.RespCombo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLable
            // 
            this.mainLable.AutoSize = true;
            this.mainLable.Location = new System.Drawing.Point(18, 19);
            this.mainLable.Name = "mainLable";
            this.mainLable.Size = new System.Drawing.Size(55, 16);
            this.mainLable.TabIndex = 36;
            this.mainLable.Text = "Проект";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(22, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 727);
            this.panel1.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RespCombo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(4, 322);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1301, 401);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Формирование команды";
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
            this.DCreate,
            this.Patronymic,
            this.Post,
            this.Qualification});
            this.dataGridView2.Location = new System.Drawing.Point(8, 105);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1285, 276);
            this.dataGridView2.TabIndex = 14;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.HeaderText = "Фамилия";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // DCreate
            // 
            this.DCreate.HeaderText = "Имя";
            this.DCreate.MinimumWidth = 6;
            this.DCreate.Name = "DCreate";
            this.DCreate.ReadOnly = true;
            this.DCreate.Width = 150;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DPEnd);
            this.groupBox1.Controls.Add(this.DFStart);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.DescriptionTextBox);
            this.groupBox1.Controls.Add(this.DFEnd);
            this.groupBox1.Controls.Add(this.DPStart);
            this.groupBox1.Controls.Add(this.DCreate2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(911, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Факт. дата начала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1104, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Факт.  дата завершения";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "План. дата начала";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "План.  дата завершения";
            // 
            // DCreate2
            // 
            this.DCreate2.AutoSize = true;
            this.DCreate2.Location = new System.Drawing.Point(381, 43);
            this.DCreate2.Name = "DCreate2";
            this.DCreate2.Size = new System.Drawing.Size(51, 16);
            this.DCreate2.TabIndex = 44;
            this.DCreate2.Text = "label10";
            // 
            // DPStart
            // 
            this.DPStart.AutoSize = true;
            this.DPStart.Location = new System.Drawing.Point(12, 263);
            this.DPStart.Name = "DPStart";
            this.DPStart.Size = new System.Drawing.Size(51, 16);
            this.DPStart.TabIndex = 45;
            this.DPStart.Text = "label11";
            // 
            // DFEnd
            // 
            this.DFEnd.AutoSize = true;
            this.DFEnd.Location = new System.Drawing.Point(1108, 263);
            this.DFEnd.Name = "DFEnd";
            this.DFEnd.Size = new System.Drawing.Size(0, 16);
            this.DFEnd.TabIndex = 46;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.AutoSize = true;
            this.DescriptionTextBox.Location = new System.Drawing.Point(9, 102);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(51, 16);
            this.DescriptionTextBox.TabIndex = 47;
            this.DescriptionTextBox.Text = "label13";
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSize = true;
            this.NameTextBox.Location = new System.Drawing.Point(9, 43);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(51, 16);
            this.NameTextBox.TabIndex = 48;
            this.NameTextBox.Text = "label14";
            // 
            // DFStart
            // 
            this.DFStart.AutoSize = true;
            this.DFStart.Location = new System.Drawing.Point(915, 263);
            this.DFStart.Name = "DFStart";
            this.DFStart.Size = new System.Drawing.Size(0, 16);
            this.DFStart.TabIndex = 49;
            // 
            // DPEnd
            // 
            this.DPEnd.AutoSize = true;
            this.DPEnd.Location = new System.Drawing.Point(205, 263);
            this.DPEnd.Name = "DPEnd";
            this.DPEnd.Size = new System.Drawing.Size(51, 16);
            this.DPEnd.TabIndex = 50;
            this.DPEnd.Text = "label16";
            // 
            // RespCombo
            // 
            this.RespCombo.AutoSize = true;
            this.RespCombo.Location = new System.Drawing.Point(9, 43);
            this.RespCombo.Name = "RespCombo";
            this.RespCombo.Size = new System.Drawing.Size(51, 16);
            this.RespCombo.TabIndex = 51;
            this.RespCombo.Text = "label17";
            // 
            // ShowSecondSingleProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 788);
            this.Controls.Add(this.mainLable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ShowSecondSingleProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проект";
            this.Load += new System.EventHandler(this.ShowSecondSingleProject_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RespCombo;
        private System.Windows.Forms.Label DPEnd;
        private System.Windows.Forms.Label DFStart;
        private System.Windows.Forms.Label NameTextBox;
        private System.Windows.Forms.Label DescriptionTextBox;
        private System.Windows.Forms.Label DFEnd;
        private System.Windows.Forms.Label DPStart;
        private System.Windows.Forms.Label DCreate2;
    }
}