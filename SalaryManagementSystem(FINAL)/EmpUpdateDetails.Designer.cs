namespace SalaryManagementSystem
{
    partial class EmpUpdateDetails
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.empSaveButton = new System.Windows.Forms.Button();
            this.empUpdatedDetail = new System.Windows.Forms.TextBox();
            this.empEnteredDetail = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.empUpdateDetailsCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SalaryManagementSystem.Properties.Resources.ViewDetailsBackground;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 507);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.empSaveButton);
            this.panel2.Controls.Add(this.empUpdatedDetail);
            this.panel2.Controls.Add(this.empEnteredDetail);
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.empUpdateDetailsCombo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(57, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 408);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(173, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Updated detail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(173, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Update detail:";
            // 
            // empSaveButton
            // 
            this.empSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.empSaveButton.ForeColor = System.Drawing.Color.Lavender;
            this.empSaveButton.Location = new System.Drawing.Point(221, 238);
            this.empSaveButton.Name = "empSaveButton";
            this.empSaveButton.Size = new System.Drawing.Size(128, 23);
            this.empSaveButton.TabIndex = 13;
            this.empSaveButton.Text = "SAVE";
            this.empSaveButton.UseVisualStyleBackColor = true;
            this.empSaveButton.Click += new System.EventHandler(this.empSaveButton_Click);
            // 
            // empUpdatedDetail
            // 
            this.empUpdatedDetail.Location = new System.Drawing.Point(177, 321);
            this.empUpdatedDetail.Name = "empUpdatedDetail";
            this.empUpdatedDetail.Size = new System.Drawing.Size(217, 20);
            this.empUpdatedDetail.TabIndex = 10;
            // 
            // empEnteredDetail
            // 
            this.empEnteredDetail.Location = new System.Drawing.Point(177, 180);
            this.empEnteredDetail.Name = "empEnteredDetail";
            this.empEnteredDetail.Size = new System.Drawing.Size(217, 20);
            this.empEnteredDetail.TabIndex = 9;
            this.empEnteredDetail.TextChanged += new System.EventHandler(this.empEnteredDetail_TextChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.ForeColor = System.Drawing.Color.Lavender;
            this.back.Location = new System.Drawing.Point(30, 364);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(31, 23);
            this.back.TabIndex = 8;
            this.back.Text = "←";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // empUpdateDetailsCombo
            // 
            this.empUpdateDetailsCombo.FormattingEnabled = true;
            this.empUpdateDetailsCombo.Items.AddRange(new object[] {
            "Contact",
            "Email",
            "Address"});
            this.empUpdateDetailsCombo.Location = new System.Drawing.Point(177, 104);
            this.empUpdateDetailsCombo.Name = "empUpdateDetailsCombo";
            this.empUpdateDetailsCombo.Size = new System.Drawing.Size(217, 21);
            this.empUpdateDetailsCombo.TabIndex = 4;
            this.empUpdateDetailsCombo.Text = "Select Detail";
            this.empUpdateDetailsCombo.SelectedIndexChanged += new System.EventHandler(this.empUpdateDetailsCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(169, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Update Details";
            // 
            // EmpUpdateDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 493);
            this.Controls.Add(this.panel1);
            this.Name = "EmpUpdateDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpUpdateDetails";
            this.Load += new System.EventHandler(this.EmpUpdateValues_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox empUpdateDetailsCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox empUpdatedDetail;
        private System.Windows.Forms.TextBox empEnteredDetail;
        private System.Windows.Forms.Button empSaveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}