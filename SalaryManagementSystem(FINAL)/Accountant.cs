using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SalaryManagementSystem
{
    class Accountant
    {
        public static string connectionString = @"Data Source=DESKTOP-LC5RP43;Initial Catalog=SMS;Integrated Security=True";
        //public static string connectionString = @"Data Source=DESKTOP-TMA6F62\MYSQLSERVER; Initial Catalog=SMS;Integrated Security=True";
        public static SqlConnection sqlcon = new SqlConnection(connectionString);

        public static void OpenConection()
        {
            sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
        }
        public static void loginAccountant(string user, string password)
        {
           // string loginQ = "select * from Accountant where username = '" + user + "' and password = '" + password + "'";
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Accountant where username = '" + user + "' and password = '" + password + "'", sqlcon);
            DataTable dtbl1 = new DataTable();
            sqlda.Fill(dtbl1);
            try
            {
                if (dtbl1.Rows.Count == 1)
                {
                    AccountantLogin.showForm = true;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                AccountantLogin.showForm = false;
                MessageBox.Show("Incorrect Accountant ID or Password!");
            }
        }
    }
}
