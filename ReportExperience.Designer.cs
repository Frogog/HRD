﻿namespace HRD
{
    partial class ReportExperience
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRD_DBDataSet = new HRD.HRD_DBDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.createB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkQualificationB = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new HRD.HRD_DBDataSetTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 62);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 24);
            this.comboBox1.TabIndex = 34;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.hRD_DBDataSet;
            // 
            // hRD_DBDataSet
            // 
            this.hRD_DBDataSet.DataSetName = "HRD_DBDataSet";
            this.hRD_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Кто составил";
            // 
            // createB
            // 
            this.createB.Location = new System.Drawing.Point(345, 136);
            this.createB.Margin = new System.Windows.Forms.Padding(4);
            this.createB.Name = "createB";
            this.createB.Size = new System.Drawing.Size(133, 28);
            this.createB.TabIndex = 32;
            this.createB.Text = "Сформировать";
            this.createB.UseVisualStyleBackColor = true;
            this.createB.Click += new System.EventHandler(this.createB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Отчет \"Опытность ответственных\"";
            // 
            // checkQualificationB
            // 
            this.checkQualificationB.Location = new System.Drawing.Point(275, 60);
            this.checkQualificationB.Margin = new System.Windows.Forms.Padding(4);
            this.checkQualificationB.Name = "checkQualificationB";
            this.checkQualificationB.Size = new System.Drawing.Size(33, 28);
            this.checkQualificationB.TabIndex = 35;
            this.checkQualificationB.Text = "...";
            this.checkQualificationB.UseVisualStyleBackColor = true;
            this.checkQualificationB.Click += new System.EventHandler(this.checkQualificationB_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // ReportExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 181);
            this.Controls.Add(this.checkQualificationB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ReportExperience";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет \"Опытность ответственных\"";
            this.Load += new System.EventHandler(this.ReportExperience_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRD_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkQualificationB;
        private HRD_DBDataSet hRD_DBDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private HRD_DBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}