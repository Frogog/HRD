namespace HRD
{
    partial class ShowAllPostForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QualificationКвалификацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmB = new System.Windows.Forms.Button();
            this.canselB = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.deleteB = new System.Windows.Forms.Button();
            this.changeB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            this.showPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainLable = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.showPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GuideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GuideToolStripMenuItem
            // 
            this.GuideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeToolStripMenuItem,
            this.PostToolStripMenuItem,
            this.QualificationКвалификацииToolStripMenuItem});
            this.GuideToolStripMenuItem.Name = "GuideToolStripMenuItem";
            this.GuideToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.GuideToolStripMenuItem.Text = "Справочники";
            // 
            // EmployeeToolStripMenuItem
            // 
            this.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem";
            this.EmployeeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.EmployeeToolStripMenuItem.Text = "Сотрудники";
            // 
            // PostToolStripMenuItem
            // 
            this.PostToolStripMenuItem.Name = "PostToolStripMenuItem";
            this.PostToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.PostToolStripMenuItem.Text = "Должности";
            // 
            // QualificationКвалификацииToolStripMenuItem
            // 
            this.QualificationКвалификацииToolStripMenuItem.Name = "QualificationКвалификацииToolStripMenuItem";
            this.QualificationКвалификацииToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.QualificationКвалификацииToolStripMenuItem.Text = "Уровни квалификации";
            // 
            // confirmB
            // 
            this.confirmB.Location = new System.Drawing.Point(257, 75);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(100, 23);
            this.confirmB.TabIndex = 27;
            this.confirmB.Text = "ОК";
            this.confirmB.UseVisualStyleBackColor = true;
            this.confirmB.Visible = false;
            // 
            // canselB
            // 
            this.canselB.Location = new System.Drawing.Point(363, 75);
            this.canselB.Name = "canselB";
            this.canselB.Size = new System.Drawing.Size(100, 23);
            this.canselB.TabIndex = 26;
            this.canselB.Text = "Отмена";
            this.canselB.UseVisualStyleBackColor = true;
            this.canselB.Visible = false;
            this.canselB.Click += new System.EventHandler(this.canselB_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.label13);
            this.panelAdd.Controls.Add(this.textBox10);
            this.panelAdd.Location = new System.Drawing.Point(11, 26);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(460, 43);
            this.panelAdd.TabIndex = 22;
            this.panelAdd.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Должность";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(7, 20);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(445, 20);
            this.textBox10.TabIndex = 16;
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(476, 133);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(100, 23);
            this.deleteB.TabIndex = 25;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = true;
            // 
            // changeB
            // 
            this.changeB.Location = new System.Drawing.Point(476, 75);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(100, 23);
            this.changeB.TabIndex = 24;
            this.changeB.Text = "Редактировать";
            this.changeB.UseVisualStyleBackColor = true;
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(476, 46);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(100, 23);
            this.addB.TabIndex = 23;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // showPanel
            // 
            this.showPanel.Controls.Add(this.dataGridView1);
            this.showPanel.Controls.Add(this.mainLable);
            this.showPanel.Location = new System.Drawing.Point(11, 26);
            this.showPanel.Margin = new System.Windows.Forms.Padding(2);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(460, 406);
            this.showPanel.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Post});
            this.dataGridView1.Location = new System.Drawing.Point(2, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(456, 387);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Post
            // 
            this.Post.HeaderText = "Должность";
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            // 
            // mainLable
            // 
            this.mainLable.AutoSize = true;
            this.mainLable.Location = new System.Drawing.Point(2, 2);
            this.mainLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mainLable.Name = "mainLable";
            this.mainLable.Size = new System.Drawing.Size(131, 13);
            this.mainLable.TabIndex = 3;
            this.mainLable.Text = "Справочник должностей";
            // 
            // ShowAllPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 440);
            this.Controls.Add(this.confirmB);
            this.Controls.Add(this.canselB);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.changeB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ShowAllPostForm";
            this.Text = "Должности";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.showPanel.ResumeLayout(false);
            this.showPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QualificationКвалификацииToolStripMenuItem;
        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.Button canselB;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button changeB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Panel showPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label mainLable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
    }
}