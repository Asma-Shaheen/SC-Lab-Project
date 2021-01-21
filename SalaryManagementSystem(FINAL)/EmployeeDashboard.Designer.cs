namespace SalaryManagementSystem
{
    partial class EmployeeDashboard
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
            this.UpdateDetailsButton = new System.Windows.Forms.Button();
            this.ViewDetailsButton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SalaryManagementSystem.Properties.Resources.photo_1521449256184_170b4a4c437c__1_;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 456);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.UpdateDetailsButton);
            this.panel2.Controls.Add(this.ViewDetailsButton);
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(52, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 365);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // UpdateDetailsButton
            // 
            this.UpdateDetailsButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateDetailsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpdateDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.UpdateDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateDetailsButton.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDetailsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateDetailsButton.Location = new System.Drawing.Point(104, 221);
            this.UpdateDetailsButton.Name = "UpdateDetailsButton";
            this.UpdateDetailsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UpdateDetailsButton.Size = new System.Drawing.Size(228, 66);
            this.UpdateDetailsButton.TabIndex = 9;
            this.UpdateDetailsButton.Text = "Update Details";
            this.UpdateDetailsButton.UseVisualStyleBackColor = false;
            this.UpdateDetailsButton.Click += new System.EventHandler(this.UpdateDetailsButton_Click);
            // 
            // ViewDetailsButton
            // 
            this.ViewDetailsButton.BackColor = System.Drawing.Color.Transparent;
            this.ViewDetailsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ViewDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ViewDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewDetailsButton.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDetailsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewDetailsButton.Location = new System.Drawing.Point(104, 123);
            this.ViewDetailsButton.Name = "ViewDetailsButton";
            this.ViewDetailsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ViewDetailsButton.Size = new System.Drawing.Size(228, 66);
            this.ViewDetailsButton.TabIndex = 8;
            this.ViewDetailsButton.Text = "View Details";
            this.ViewDetailsButton.UseVisualStyleBackColor = false;
            this.ViewDetailsButton.Click += new System.EventHandler(this.ViewDetailsButton_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.ForeColor = System.Drawing.Color.Lavender;
            this.back.Location = new System.Drawing.Point(22, 316);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(31, 23);
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
            this.label1.Location = new System.Drawing.Point(70, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Dashboard";
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDashboard";
            this.Load += new System.EventHandler(this.EmployeeDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewDetailsButton;
        private System.Windows.Forms.Button UpdateDetailsButton;
    }
}