namespace SalaryManagementSystem
{
    partial class MainMenu
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
            this.EmpButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountButton = new System.Windows.Forms.Button();
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
            this.panel1.Font = new System.Drawing.Font("Vivaldi", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 471);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.EmpButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.AccountButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(79, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 405);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // EmpButton
            // 
            this.EmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmpButton.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpButton.Location = new System.Drawing.Point(170, 299);
            this.EmpButton.Name = "EmpButton";
            this.EmpButton.Size = new System.Drawing.Size(182, 66);
            this.EmpButton.TabIndex = 2;
            this.EmpButton.Text = "Employee";
            this.EmpButton.UseVisualStyleBackColor = true;
            this.EmpButton.Click += new System.EventHandler(this.EmpButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(199, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGIN AS:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // AccountButton
            // 
            this.AccountButton.BackColor = System.Drawing.Color.Transparent;
            this.AccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AccountButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AccountButton.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountButton.Location = new System.Drawing.Point(170, 192);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AccountButton.Size = new System.Drawing.Size(182, 66);
            this.AccountButton.TabIndex = 1;
            this.AccountButton.Text = "Accountant";
            this.AccountButton.UseVisualStyleBackColor = false;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 467);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EmpButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}

