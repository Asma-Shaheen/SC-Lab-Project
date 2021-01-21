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
    public partial class AddSalaryDetails : Form
    {
        public AddSalaryDetails()
        {
            InitializeComponent();
        }
        SalaryCalculation obj = new SalaryCalculation();
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddSalDetailsButton_Click(object sender, EventArgs e)
        {
            if (EmpIdtxt.Text != "")
            {
                double store = obj.days(double.Parse(FullDays_txt.Text), double.Parse(HalfDays_txt.Text.Trim()));
                WorkHours_txt.Text = store.ToString();
                double basic = obj.workingdays(double.Parse(WorkHours_txt.Text));
                BasicSalary_txt.Text = basic.ToString();
                double allowance = obj.allowance(double.Parse(BasicSalary_txt.Text));
                allowance_txt.Text = allowance.ToString();
                double grosspay = obj.grosspay(double.Parse(allowance_txt.Text), double.Parse(BasicSalary_txt.Text));
                GrossPay_txt.Text = grosspay.ToString();
                double incometax = obj.Incometax(double.Parse(BasicSalary_txt.Text), double.Parse(GrossPay_txt.Text));
                IncomeTax_txt.Text = incometax.ToString();
                string performance = obj.performance(double.Parse(WorkHours_txt.Text));
                performance_txt.Text = performance;
                double netpay = obj.netsalary(double.Parse(BasicSalary_txt.Text), double.Parse(IncomeTax_txt.Text));
                netpay_txt.Text = netpay.ToString();
                try
                {
                    if (WorkHours_txt.Text == "0")
                    {
                        throw new Exception();
                    }
                    else
                        SalaryCalculation.InsertSalaryDetails(EmpIdtxt.Text, Designation_txt.Text, FullDays_txt.Text, HalfDays_txt.Text, LeaveDays_txt.Text, WorkHours_txt.Text, allowance_txt.Text, BasicSalary_txt.Text, GrossPay_txt.Text, IncomeTax_txt.Text, netpay_txt.Text, performance_txt.Text);
                    MessageBox.Show("Record Inserted Successfully");
                }
                catch (Exception)
                {

                    MessageBox.Show("INvalid Days Entered!");
                }
            }
            else { MessageBox.Show("Must fill Empty Spaces!"); }
          

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountantDashboard eD = new AccountantDashboard();
            eD.ShowDialog();
            this.Close();
        }

        private void AddSalaryDetails_Load_1(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(80, 0, 0, 0);
            AddSalDetailsButton.BackColor = Color.FromArgb(40, 20, 0, 0);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void EmpIdtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeaveDays_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
