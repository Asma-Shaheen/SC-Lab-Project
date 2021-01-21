using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace SalaryManagementSystem
{
    public partial class updateSalaryDetails : Form
    {
        public updateSalaryDetails()
        {
            InitializeComponent();
        }
        SalaryCalculation obj = new SalaryCalculation();
        private void updateSalaryDetails_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(80, 0, 0, 0);
            UpdateSalDetailsButton.BackColor = Color.FromArgb(40, 20, 0, 0);
        }

        private void UpdateSalDetailsButton_Click(object sender, EventArgs e)
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
                    {
                        Employee.Updateemployeesalarydetails(EmpIdtxt.Text, Designation_txt.Text, FullDays_txt.Text, HalfDays_txt.Text, LeaveDays_txt.Text, WorkHours_txt.Text, allowance_txt.Text, BasicSalary_txt.Text, GrossPay_txt.Text, IncomeTax_txt.Text, netpay_txt.Text, performance_txt.Text);
                        MessageBox.Show("Record Updated Successfully");
                        dataGridView1.DataSource = Employee.searchemployeesalarydetails(EmpIdtxt.Text);
                        totalsalary_txt.Text = netpay_txt.Text;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Invalid Days Entered!");
                }
            
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountantDashboard eD = new AccountantDashboard();
            eD.ShowDialog();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void EmpIdtxt_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LC5RP43;Initial Catalog=SMS;Integrated Security=True");
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TMA6F62\MYSQLSERVER; Initial Catalog=SMS;Integrated Security=True");

            con.Open();
            if (EmpIdtxt.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select Full_Days,Half_Days,Leave_Days,Designation from salary_details where Employeee_ID = '" + EmpIdtxt.Text + "'", con);
                cmd.Parameters.AddWithValue(EmpIdtxt.Text, double.Parse(EmpIdtxt.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    FullDays_txt.Text = da.GetValue(0).ToString();
                    HalfDays_txt.Text = da.GetValue(1).ToString();
                    LeaveDays_txt.Text = da.GetValue(2).ToString();
                    Designation_txt.Text = da.GetValue(3).ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LeaveDays_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BasicSalary_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
        
    }
    

