using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalaryManagementSystem
{
    public class SalaryCalculation
    {
        public double days(double fulldays, double halfdays)
        {
            try
            {
            if ( fulldays + halfdays >= 31 )
            {
                    throw new Exception();
            }
                return ((fulldays * 8) + (halfdays * 4));
            }
            catch (Exception)
            {

               // MessageBox.Show("Invalid days entered");
                return 0;
            }
         
        }
        public double workingdays(double workdays)
            {
            return (workdays*500);
}
        public double allowance(double Basic_salary)
        {
            if (Basic_salary >= 75000)
            {
               return(Basic_salary * 0.10);
            }
            else if (Basic_salary >= 100000)
            {
                return (Basic_salary * 0.20);
            }
            else
            {
                return (Basic_salary * 0.05);
            } 
        }

        public double grosspay(double allowance, double Basic_salary)
        {
            return (allowance + Basic_salary);
        }
        public double Incometax(double Basic_salary, double grosspay)
        {
            if (Basic_salary >= 80000)
            {
                return (grosspay * 0.03);
            }
            else if (Basic_salary>= 1015000)
            {
                return (grosspay * 0.05);
            }
            else
            {
                return (grosspay * 0.01);
            }
        }
        public string performance(double workhours)
        {
            if (workhours >= 240)
            {
                return "100%";
            }
            else if (workhours >= 195)
            {
                return "70%";
            }
            else if (workhours >= 120)
            {
                return "50%";
            }
            else if (workhours >= 95)
            {
                return "30%";
            }
            else if (workhours >= 1)
            {
                return "10%";
            }
            else 
            {
                return "";
            }

        }
        public double netsalary(double basic,double income)
        {
            return (basic-income);
        }

        //public static string connectionString = @"Data Source = ARSH; Initial Catalog = SMS; Integrated Security = True";
        public static string connectionString = @"Data Source=DESKTOP-LC5RP43;Initial Catalog=SMS;Integrated Security=True";
        public static SqlConnection sqlcon = new SqlConnection(connectionString);

        public  static void OpenConection()
        {
            sqlcon = new SqlConnection(connectionString);               
            sqlcon.Open();
        }
        public static void InsertSalaryDetails(string E_Id,string Designation,string FullDays,string halfDays,string leavedays,
            string workHours,string allowance,string BasicSalary,string grosspay,string incometax,string netpay,string performance)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("insert into salary_details values ('" + E_Id + "','" + Designation+ "','" + FullDays + "','" + halfDays + "','" + leavedays + "','" +workHours + "','" + allowance + "','" + BasicSalary + "','" + grosspay + "','" + incometax + "','" + netpay + "','" + performance + "')", connectionString);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
        }
       
    }
}
