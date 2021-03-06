﻿namespace SalaryManagementSystem
{
    partial class EmployeeLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.EmpLogin = new System.Windows.Forms.Button();
            this.EmpPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::SalaryManagementSystem.Properties.Resources.photo_1521449256184_170b4a4c437c__1_;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 453);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.EmpLogin);
            this.panel2.Controls.Add(this.EmpPass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.EmpID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(39, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 374);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.ForeColor = System.Drawing.Color.Lavender;
            this.back.Location = new System.Drawing.Point(23, 316);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(31, 23);
            this.back.TabIndex = 7;
            this.back.Text = "←";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // EmpLogin
            // 
            this.EmpLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmpLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpLogin.ForeColor = System.Drawing.Color.Lavender;
            this.EmpLogin.Location = new System.Drawing.Point(183, 311);
            this.EmpLogin.Name = "EmpLogin";
            this.EmpLogin.Size = new System.Drawing.Size(121, 33);
            this.EmpLogin.TabIndex = 6;
            this.EmpLogin.Text = "Login";
            this.EmpLogin.UseVisualStyleBackColor = true;
            this.EmpLogin.Click += new System.EventHandler(this.EmpLogin_Click);
            // 
            // EmpPass
            // 
            this.EmpPass.Location = new System.Drawing.Point(73, 245);
            this.EmpPass.Name = "EmpPass";
            this.EmpPass.PasswordChar = '●';
            this.EmpPass.Size = new System.Drawing.Size(333, 20);
            this.EmpPass.TabIndex = 5;
            this.EmpPass.TextChanged += new System.EventHandler(this.EmpPass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(69, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // EmpID
            // 
            this.EmpID.BackColor = System.Drawing.SystemColors.Window;
            this.EmpID.Location = new System.Drawing.Point(73, 149);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(333, 20);
            this.EmpID.TabIndex = 3;
            this.EmpID.TextChanged += new System.EventHandler(this.EmpID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(69, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(137, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Login";
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeLogin";
            this.Load += new System.EventHandler(this.EmployeeLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button EmpLogin;
        private System.Windows.Forms.TextBox EmpPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmpID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}