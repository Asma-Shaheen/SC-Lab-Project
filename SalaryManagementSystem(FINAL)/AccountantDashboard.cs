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
    public partial class AccountantDashboard : Form
    {
        public AccountantDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewEmployee VE = new ViewEmployee();
            VE.ShowDialog();
            this.Close();
        }

        private void AccountantDashboard_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(80, 0, 0, 0);
            AddEmployeeButton.BackColor = Color.FromArgb(40, 20, 0, 0);
            DeleteEmployeeButton.BackColor = Color.FromArgb(40, 20, 0, 0);
            ViewEmployeeButton.BackColor = Color.FromArgb(40, 20, 0, 0);
            SearchEmployeeButton.BackColor = Color.FromArgb(40, 20, 0, 0);
            AddSalaryDetailsButton.BackColor = Color.FromArgb(40, 20, 0, 0);
            UpdateSalaryDetailsButton.BackColor = Color.FromArgb(40, 20, 0, 0);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
            this.Close();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee AE = new AddEmployee();
            AE.ShowDialog();
            this.Close();
        }

        private void SearchEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchEmployee SE = new SearchEmployee();
            SE.ShowDialog();
            this.Close();
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteEmployee DE = new DeleteEmployee();
            DE.ShowDialog();
            this.Close();

        }

        private void AddSalaryDetailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSalaryDetails ASD = new AddSalaryDetails();
            ASD.ShowDialog();
            this.Close();
        }

        private void UpdateSalaryDetailsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateSalaryDetails USD = new updateSalaryDetails();
            USD.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
