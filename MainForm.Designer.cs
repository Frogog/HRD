﻿namespace HRD
{
    partial class MainForm
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GuideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.EmployeeToolStripMenuItem.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // PostToolStripMenuItem
            // 
            this.PostToolStripMenuItem.Name = "PostToolStripMenuItem";
            this.PostToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.PostToolStripMenuItem.Text = "Должности";
            this.PostToolStripMenuItem.Click += new System.EventHandler(this.PostToolStripMenuItem_Click);
            // 
            // QualificationКвалификацииToolStripMenuItem
            // 
            this.QualificationКвалификацииToolStripMenuItem.Name = "QualificationКвалификацииToolStripMenuItem";
            this.QualificationКвалификацииToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.QualificationКвалификацииToolStripMenuItem.Text = "Уровни квалификации";
            this.QualificationКвалификацииToolStripMenuItem.Click += new System.EventHandler(this.QualificationКвалификацииToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QualificationКвалификацииToolStripMenuItem;
    }
}