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
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(80, 0, 0, 0);
            ViewDetailsButton.BackColor = Color.FromArgb(40, 20, 0, 0);
            UpdateDetailsButton.BackColor = Color.FromArgb(40, 20, 0, 0);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            this.Close();
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpViewDetails evd = new EmpViewDetails();
            evd.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateDetailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpUpdateDetails eud = new EmpUpdateDetails();
            eud.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
