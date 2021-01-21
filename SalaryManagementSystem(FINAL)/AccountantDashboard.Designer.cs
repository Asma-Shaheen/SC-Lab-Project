
using System;

namespace SalaryManagementSystem
{
    partial class AccountantDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountantDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpdateSalaryDetailsButton = new System.Windows.Forms.Button();
            this.AddSalaryDetailsButton = new System.Windows.Forms.Button();
            this.ViewEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.SearchEmployeeButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 505);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.UpdateSalaryDetailsButton);
            this.panel2.Controls.Add(this.AddSalaryDetailsButton);
            this.panel2.Controls.Add(this.ViewEmployeeButton);
            this.panel2.Controls.Add(this.DeleteEmployeeButton);
            this.panel2.Controls.Add(this.SearchEmployeeButton);
            this.panel2.Controls.Add(this.AddEmployeeButton);
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(88, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 420);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // UpdateSalaryDetailsButton
            // 
            this.UpdateSalaryDetailsButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateSalaryDetailsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateSalaryDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.UpdateSalaryDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateSalaryDetailsButton.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSalaryDetailsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateSalaryDetailsButton.Location = new System.Drawing.Point(114, 337);
            this.UpdateSalaryDetailsButton.Name = "UpdateSalaryDetailsButton";
            this.UpdateSalaryDetailsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UpdateSalaryDetailsButton.Size = new System.Drawing.Size(243, 35);
            this.UpdateSalaryDetailsButton.TabIndex = 14;
            this.UpdateSalaryDetailsButton.Text = "Update Salary Details";
            this.UpdateSalaryDetailsButton.UseVisualStyleBackColor = false;
            this.UpdateSalaryDetailsButton.Click += new System.EventHandler(this.UpdateSalaryDetailsButton_Click);
            // 
            // AddSalaryDetailsButton
            // 
            this.AddSalaryDetailsButton.BackColor = System.Drawing.Color.Transparent;
            this.AddSalaryDetailsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddSalaryDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.AddSalaryDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSalaryDetailsButton.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSalaryDetailsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddSalaryDetailsButton.Location = new System.Drawing.Point(114, 288);
            this.AddSalaryDetailsButton.Name = "AddSalaryDetailsButton";
            this.AddSalaryDetailsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddSalaryDetailsButton.Size = new System.Drawing.Size(243, 35);
            this.AddSalaryDetailsButton.TabIndex = 13;
            this.AddSalaryDetailsButton.Text = "Add Salary Details";
            this.AddSalaryDetailsButton.UseVisualStyleBackColor = false;
            this.AddSalaryDetailsButton.Click += new System.EventHandler(this.AddSalaryDetailsButton_Click);
            // 
            // ViewEmployeeButton
            // 
            this.ViewEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.ViewEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ViewEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ViewEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewEmployeeButton.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEmployeeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewEmployeeButton.Location = new System.Drawing.Point(114, 140);
            this.ViewEmployeeButton.Name = "ViewEmployeeButton";
            this.ViewEmployeeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ViewEmployeeButton.Size = new System.Drawing.Size(243, 35);
            this.ViewEmployeeButton.TabIndex = 12;
            this.ViewEmployeeButton.Text = "View Employee";
            this.ViewEmployeeButton.UseVisualStyleBackColor = false;
            this.ViewEmployeeButton.Click += new System.EventHandler(this.ViewEmployeeButton_Click);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.DeleteEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteEmployeeButton.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEmployeeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(114, 240);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(243, 35);
            this.DeleteEmployeeButton.TabIndex = 11;
            this.DeleteEmployeeButton.Text = "Delete Employee";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = false;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // SearchEmployeeButton
            // 
            this.SearchEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SearchEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchEmployeeButton.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEmployeeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchEmployeeButton.Location = new System.Drawing.Point(114, 191);
            this.SearchEmployeeButton.Name = "SearchEmployeeButton";
            this.SearchEmployeeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SearchEmployeeButton.Size = new System.Drawing.Size(243, 35);
            this.SearchEmployeeButton.TabIndex = 10;
            this.SearchEmployeeButton.Text = "Search Employee";
            this.SearchEmployeeButton.UseVisualStyleBackColor = false;
            this.SearchEmployeeButton.Click += new System.EventHandler(this.SearchEmployeeButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.AddEmployeeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddEmployeeButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.AddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddEmployeeButton.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddEmployeeButton.Location = new System.Drawing.Point(114, 91);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddEmployeeButton.Size = new System.Drawing.Size(243, 35);
            this.AddEmployeeButton.TabIndex = 8;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = false;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Lavender;
            this.back.Location = new System.Drawing.Point(23, 375);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(33, 31);
            this.back.TabIndex = 7;
            this.back.Text = "←";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accountant Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AccountantDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 503);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountantDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountantDashboard";
            this.Load += new System.EventHandler(this.AccountantDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void UpdateDetailsButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddSalaryDetailsButton;
        private System.Windows.Forms.Button ViewEmployeeButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button SearchEmployeeButton;
        private System.Windows.Forms.Button UpdateSalaryDetailsButton;
    }
}