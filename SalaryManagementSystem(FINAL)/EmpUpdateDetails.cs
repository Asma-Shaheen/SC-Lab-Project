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
    public partial class EmpUpdateDetails : Form
    {
        public static string updateContact;
        public static string updateEmail;
        public static string updateAddress;
        public EmpUpdateDetails()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmpUpdateValues_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(80, 0, 0, 0);
            empSaveButton.BackColor = Color.FromArgb(40, 20, 0, 0);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeDashboard eD = new EmployeeDashboard();
            eD.ShowDialog();
            this.Close();
        }

        private void empSaveButton_Click(object sender, EventArgs e)
        {
            if (empUpdateDetailsCombo.SelectedIndex == 0)
            {
                Employee.updateEmployeeContact(empEnteredDetail.Text);
                empUpdatedDetail.Text = updateContact;
            }
            else if (empUpdateDetailsCombo.SelectedIndex == 1)
            {
                Employee.updateEmployeeEmail(empEnteredDetail.Text);
                empUpdatedDetail.Text = updateEmail;
            }
            else if (empUpdateDetailsCombo.SelectedIndex == 2)
            {
                Employee.updateEmployeeAddress(empEnteredDetail.Text);
                empUpdatedDetail.Text = updateAddress;
            }
        }

        private void empUpdateDetailsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (empUpdateDetailsCombo.SelectedIndex == 0)
            {
                empEnteredDetail.Clear();
                empUpdatedDetail.Clear();
            }
            else if (empUpdateDetailsCombo.SelectedIndex == 1)
            {
                empEnteredDetail.Clear();
                empUpdatedDetail.Clear();
            }
            else if (empUpdateDetailsCombo.SelectedIndex == 2)
            {
                empEnteredDetail.Clear();
                empUpdatedDetail.Clear();
            }
        }

        private void empEnteredDetail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
