using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagementSystem
{
    public partial class EmpViewDetails : Form
    {
        
        public EmpViewDetails()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeDashboard eD = new EmployeeDashboard();
            eD.ShowDialog();
            this.Close();
        }

        private void EmpViewDetails_Load(object sender, EventArgs e)
        {
            back.BackColor = Color.FromArgb(40, 20, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Employee.showEmployeebyID(Employee.employeeID.ToString());
            dataGridView2.DataSource = Employee.searchemployeesalarydetails(Employee.employeeID.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
