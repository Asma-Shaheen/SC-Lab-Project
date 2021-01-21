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
    public partial class EmployeeLogin : Form
    {
        public static bool showForm;
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
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

        private void EmpLogin_Click(object sender, EventArgs e)
        {
            Employee.loginEmployee(EmpID.Text.Trim(), EmpPass.Text.Trim());
            if (showForm == true)
            {
                this.Hide();
                EmployeeDashboard eD = new EmployeeDashboard();
                eD.ShowDialog();
                this.Close();
            }
        }

        private void EmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
