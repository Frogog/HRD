namespace HRD
{
    partial class ShowAllQualificationForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteB = new System.Windows.Forms.Button();
            this.changeB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            this.showPanel = new System.Windows.Forms.Panel();
            this.mainLable = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.canselB = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.confirmB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.showPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Post,
            this.koef});
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(453, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // Post
            // 
            this.Post.HeaderText = "Уровень";
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            this.Post.Width = 350;
            // 
            // koef
            // 
            this.koef.HeaderText = "Коэффициент";
            this.koef.Name = "koef";
            this.koef.ReadOnly = true;
            this.koef.Width = 50;
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(478, 112);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(100, 23);
            this.deleteB.TabIndex = 33;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = true;
            // 
            // changeB
            // 
            this.changeB.Location = new System.Drawing.Point(478, 54);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(100, 23);
            this.changeB.TabIndex = 32;
            this.changeB.Text = "Редактировать";
            this.changeB.UseVisualStyleBackColor = true;
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(478, 25);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(100, 23);
            this.addB.TabIndex = 31;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // showPanel
            // 
            this.showPanel.Controls.Add(this.dataGridView1);
            this.showPanel.Location = new System.Drawing.Point(16, 25);
            this.showPanel.Margin = new System.Windows.Forms.Padding(2);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(457, 387);
            this.showPanel.TabIndex = 29;
            // 
            // mainLable
            // 
            this.mainLable.AutoSize = true;
            this.mainLable.Location = new System.Drawing.Point(13, 9);
            this.mainLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainLable.Name = "mainLable";
            this.mainLable.Size = new System.Drawing.Size(188, 13);
            this.mainLable.TabIndex = 3;
            this.mainLable.Text = "Справочник уровней квалификации";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Наименование";
            // 
            // canselB
            // 
            this.canselB.Location = new System.Drawing.Point(372, 174);
            this.canselB.Name = "canselB";
            this.canselB.Size = new System.Drawing.Size(100, 23);
            this.canselB.TabIndex = 34;
            this.canselB.Text = "Отмена";
            this.canselB.UseVisualStyleBackColor = true;
            this.canselB.Visible = false;
            this.canselB.Click += new System.EventHandler(this.canselB_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(7, 35);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(444, 20);
            this.textBox10.TabIndex = 16;
            // 
            // confirmB
            // 
            this.confirmB.Location = new System.Drawing.Point(266, 174);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(100, 23);
            this.confirmB.TabIndex = 35;
            this.confirmB.Text = "ОК";
            this.confirmB.UseVisualStyleBackColor = true;
            this.confirmB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Коэффициент";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(16, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 143);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общие данные";
            // 
            // ShowAllQualificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainLable);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.changeB);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.canselB);
            this.Controls.Add(this.confirmB);
            this.Name = "ShowAllQualificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уровни квалификации";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.showPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button changeB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Panel showPanel;
        private System.Windows.Forms.Label mainLable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button canselB;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn koef;
    }
}