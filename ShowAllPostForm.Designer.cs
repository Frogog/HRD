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
            this.components = new System.ComponentModel.Container();
            this.confirmB = new System.Windows.Forms.Button();
            this.canselB = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.deleteB = new System.Windows.Forms.Button();
            this.changeB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            this.mainLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showPanel = new System.Windows.Forms.Panel();
            this.hRD_DBDataSet = new HRD.HRD_DBDataSet();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTableAdapter = new HRD.HRD_DBDataSetTableAdapters.PostTableAdapter();
            this.iDPoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.showPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmB
            // 
            this.confirmB.Location = new System.Drawing.Point(349, 219);
            this.confirmB.Margin = new System.Windows.Forms.Padding(4);
            this.confirmB.Name = "confirmB";
            this.confirmB.Size = new System.Drawing.Size(133, 28);
            this.confirmB.TabIndex = 27;
            this.confirmB.Text = "ОК";
            this.confirmB.UseVisualStyleBackColor = true;
            this.confirmB.Visible = false;
            this.confirmB.Click += new System.EventHandler(this.confirmB_Click);
            // 
            // canselB
            // 
            this.canselB.Location = new System.Drawing.Point(491, 219);
            this.canselB.Margin = new System.Windows.Forms.Padding(4);
            this.canselB.Name = "canselB";
            this.canselB.Size = new System.Drawing.Size(133, 28);
            this.canselB.TabIndex = 26;
            this.canselB.Text = "Отмена";
            this.canselB.UseVisualStyleBackColor = true;
            this.canselB.Visible = false;
            this.canselB.Click += new System.EventHandler(this.canselB_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Наименование";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(9, 43);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(591, 22);
            this.textBox10.TabIndex = 16;
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(632, 143);
            this.deleteB.Margin = new System.Windows.Forms.Padding(4);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(133, 28);
            this.deleteB.TabIndex = 25;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // changeB
            // 
            this.changeB.Location = new System.Drawing.Point(632, 71);
            this.changeB.Margin = new System.Windows.Forms.Padding(4);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(133, 28);
            this.changeB.TabIndex = 24;
            this.changeB.Text = "Редактировать";
            this.changeB.UseVisualStyleBackColor = true;
            this.changeB.Click += new System.EventHandler(this.changeB_Click);
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(632, 36);
            this.addB.Margin = new System.Windows.Forms.Padding(4);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(133, 28);
            this.addB.TabIndex = 23;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // mainLable
            // 
            this.mainLable.AutoSize = true;
            this.mainLable.Location = new System.Drawing.Point(15, 11);
            this.mainLable.Name = "mainLable";
            this.mainLable.Size = new System.Drawing.Size(169, 16);
            this.mainLable.TabIndex = 3;
            this.mainLable.Text = "Справочник должностей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Зарплата";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 101);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(16, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(608, 176);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общие данные";
            this.groupBox1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.payDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(604, 487);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // showPanel
            // 
            this.showPanel.Controls.Add(this.dataGridView1);
            this.showPanel.Location = new System.Drawing.Point(16, 36);
            this.showPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(609, 492);
            this.showPanel.TabIndex = 21;
            // 
            // hRD_DBDataSet
            // 
            this.hRD_DBDataSet.DataSetName = "HRD_DBDataSet";
            this.hRD_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "Post";
            this.postBindingSource.DataSource = this.hRD_DBDataSet;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // iDPoDataGridViewTextBoxColumn
            // 
            this.iDPoDataGridViewTextBoxColumn.DataPropertyName = "ID_Po";
            this.iDPoDataGridViewTextBoxColumn.HeaderText = "ID_Po";
            this.iDPoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPoDataGridViewTextBoxColumn.Name = "iDPoDataGridViewTextBoxColumn";
            this.iDPoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // payDataGridViewTextBoxColumn
            // 
            this.payDataGridViewTextBoxColumn.DataPropertyName = "Pay";
            this.payDataGridViewTextBoxColumn.HeaderText = "Pay";
            this.payDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payDataGridViewTextBoxColumn.Name = "payDataGridViewTextBoxColumn";
            this.payDataGridViewTextBoxColumn.ReadOnly = true;
            this.payDataGridViewTextBoxColumn.Width = 125;
            // 
            // ShowAllPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.confirmB);
            this.Controls.Add(this.mainLable);
            this.Controls.Add(this.canselB);
            this.Controls.Add(this.showPanel);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.changeB);
            this.Controls.Add(this.addB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ShowAllPostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Должности";
            this.Load += new System.EventHandler(this.ShowAllPostForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.showPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirmB;
        private System.Windows.Forms.Button canselB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button changeB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Label mainLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel showPanel;
        private HRD_DBDataSet hRD_DBDataSet;
        private System.Windows.Forms.BindingSource postBindingSource;
        private HRD_DBDataSetTableAdapters.PostTableAdapter postTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDataGridViewTextBoxColumn;
    }
}