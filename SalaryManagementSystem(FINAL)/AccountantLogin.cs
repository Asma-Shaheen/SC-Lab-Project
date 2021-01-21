using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagementSystem
{
    public partial class AccountantLogin : Form
    {
        public static bool showForm;
        public AccountantLogin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AdminPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountantLogin_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(80, 0, 0, 0);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            this.Close();
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            Accountant.loginAccountant(adminName.Text.Trim(), AdminPass.Text.Trim());
            if (showForm == true)
            {
                this.Hide();
                AccountantDashboard aD = new AccountantDashboard();
                aD.ShowDialog();
                this.Close();
            }
        }
    }
}
