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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(80, 0, 0, 0);
            AccountButton.BackColor = Color.FromArgb(40, 20, 0, 0);
            EmpButton.BackColor = Color.FromArgb(40, 20, 0, 0);

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountantLogin accountlogin = new AccountantLogin();
            accountlogin.ShowDialog();
            this.Close();
        }

        private void EmpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLogin el = new EmployeeLogin();
            el.ShowDialog();
            this.Close();
        }
    }
}
