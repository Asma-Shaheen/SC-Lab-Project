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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountantDashboard eD = new AccountantDashboard();
            eD.ShowDialog();
            this.Close();
        }

        private void AddEmpButton_Click(object sender, EventArgs e)
        {
            Employee.InsertEmployeesDetails(EmpNametxt.Text,CNICtxt.Text,Dateofbirthtxt.Text,Emailtxt.Text,ContactNotxt.Text,Addresstxt.Text, Datejoinedtxt.Text, passwordTxt.Text);
                       
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddEmployee_Load_1(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(80, 0, 0, 0);
            AddEmpButton.BackColor = Color.FromArgb(40, 20, 0, 0);
        }

        private void Emailtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Datejoinedtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CNICtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
