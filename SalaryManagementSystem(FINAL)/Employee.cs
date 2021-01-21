using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SalaryManagementSystem
{
    public class Employee
    {
        public static string connectionString = @"Data Source=DESKTOP-LC5RP43;Initial Catalog=SMS;Integrated Security=True";
        //public static string connectionString = @"Data Source=DESKTOP-TMA6F62\MYSQLSERVER; Initial Catalog=SMS;Integrated Security=True";
        public static SqlConnection sqlcon = new SqlConnection(connectionString);
        public static int employeeID;

        public static void OpenConection()
        {
            sqlcon = new SqlConnection(connectionString);
            sqlcon.Open();
        }
        public static object showEmployee()
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Employee_Details ", sqlcon);
            //join salary_details on salary_details.Employeee_ID = Employee_Details.Employeee_ID 
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            return dtbl;
        }
        public static object showEmployeebyID(string E_ID)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Employee_Details where Employeee_ID = '" + E_ID + "'", sqlcon);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            return dtbl;
        }
      
        public static void InsertEmployeesDetails(string Name, string CNIC, string DOB, string Email, string Contact_No, string Address, string Datejoin, string password)//immutable 
        {  try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(CNIC, "^[0-9]{5}-[0-9]{7}-[0-9]{1}$" ))
                {
                    try
                    {
                        if (Email.Contains("@") == true && Email.Contains(".com") == true && Email.Length <= 50)
                        {
                            try
                            {
                                if (System.Text.RegularExpressions.Regex.IsMatch(Contact_No, "^[0-9]{4}-[0-9]{7}"))
                                {
                                    try
                                    {
                                    SqlDataAdapter sqlda = new SqlDataAdapter("insert into Employee_Details values (' " + Name + "','" + CNIC + "','" + DOB + "','" + Email + "','" + Contact_No + "','" + Address + "','" + Datejoin + "')", connectionString);
                                    DataTable dtbl = new DataTable();
                                        SqlDataAdapter sqlPass = new SqlDataAdapter("insert into Employee_Login values((SELECT IDENT_CURRENT('Employee_Details')), '" + password + "')", connectionString);
                                        DataTable dtbl2 = new DataTable();
                                        sqlda.Fill(dtbl);
                                        sqlPass.Fill(dtbl2);

                                        MessageBox.Show("Record Inserted Successfully!");
                                    }
                                    catch (Exception)
                                    {

                                        MessageBox.Show("Invalid data password Entered \n Format: Maximim 10 characters allowed");

                                    }
                                    
                                }
                                else
                                {
                                    throw new Exception();
                                }   
                            }
                                catch (Exception)
                                {

                                MessageBox.Show("Invalid Contact Number! \n   Format ****-******* ");
                            }
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Invalid Email Address\n Format : ***+@+**.com");
                    }
                }
                else
                { throw new Exception(); }
            }
            catch (Exception)
            {
                MessageBox.Show("Employee CNIC invalid format.\n   Format *****-*******-*");
            }
        }

        public static void deleteemployeesDetails(string E_ID)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("delete from salary_details where Employeee_ID = '" + E_ID + "'", sqlcon);
            SqlDataAdapter sqlda1 = new SqlDataAdapter("delete from Employee_Details where Employeee_ID = '" + E_ID + "'", sqlcon);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            sqlda1.Fill(dtbl);
        }

        public static object searchemployeesDetails(string E_ID)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Employee_Details where Employeee_ID = '" + E_ID + "'", sqlcon);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            return dtbl;
        }
        public static object searchemployeesalarydetails(string E_ID)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from salary_details where Employeee_ID = '" + E_ID + "'", sqlcon);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            return dtbl;
        }

        public static void Updateemployeesalarydetails(string E_ID,string designation,string fulldays,string halfdays,string leavedays, string workHours, string allowance, string BasicSalary, string grosspay, string incometax, string netpay, string performance)
        {

            SqlDataAdapter sqlda = new SqlDataAdapter("update salary_details set Designation= '" +designation+ "' ,Full_Days = '"+fulldays+ "',Half_Days = '"+halfdays+ "',Leave_Days = '"+leavedays+ "',Work_Hours = '" + workHours + "',Allowance = '" + allowance + "',Basic_salary = '" + BasicSalary + "',Gross_pay = '" + grosspay + "',Income_Tax = '" + incometax + "',Net_pay = '" + netpay + "',Performance = '" + performance + "'  where Employeee_ID = '" + E_ID + "'", sqlcon);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
        }
        public static void loginEmployee(string id, string pass)//immutable
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(id, "^[0-9]*$"))
                {
                    string loginQuery = "select * from employee_login where employee_id = '" + id + "' and employee_password = '" + pass + "'";
                    SqlDataAdapter sqlLog = new SqlDataAdapter(loginQuery, sqlcon);
                    DataTable dtbl = new DataTable();
                    sqlLog.Fill(dtbl);
                    try
                    {
                        if (dtbl.Rows.Count == 1)
                        {
                            employeeID = int.Parse(id);
                            EmployeeLogin.showForm = true;
                        }
                        else
                        {
                            throw new ArgumentException();
                        }}
                    catch (ArgumentException)
                    {
                        EmployeeLogin.showForm = false;
                        MessageBox.Show("Incorrect Employee ID or Password!");
                    }
                }
                else
                { throw new Exception(); }
            }
            catch (Exception)
            {
                EmployeeLogin.showForm = false;
                MessageBox.Show("Employee ID must be in numbers."); 
            }
        }
        public static void updateEmployeeContact(string contact)//immutable 
        {
            OpenConection();
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(contact, "^[0-9]{4}-[0-9]{7}"))
                {
                    string contactQuery = "update employee_details set contact_no = '" + contact + "' where employeee_id = '" + employeeID + "'";
                    SqlCommand cmd = new SqlCommand(contactQuery, sqlcon);
                    try
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            EmpUpdateDetails.updateContact = contact;
                            MessageBox.Show("Update successfully!");
                        }
                        else
                        {
                            EmpUpdateDetails.updateContact = null;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Update UNSUCCESSFUL!");
                    }
                }
                else
                { throw new Exception(); }
            }
            catch (Exception)
            { MessageBox.Show("Invalid format!"); }
        }
        public static void updateEmployeeEmail(string email)
        {
            OpenConection();
            try
            {
                if (email.Contains("@") == true && email.Contains(".com") == true && email.Length <= 50)
                {
                    string emailQuery = "update employee_details set Email = '" + email + "' where employeee_id = '" + employeeID + "'";
                    SqlCommand cmd = new SqlCommand(emailQuery, sqlcon);
                    try
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Update successfully!");
                            EmpUpdateDetails.updateEmail = email;
                        }
                        else
                        {
                            EmpUpdateDetails.updateEmail = null;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Update unsuccessful!");
                    }
                }
                else
                { throw new Exception(); }
            }
            catch (Exception)
            { MessageBox.Show("Invalid format!"); }
        }
        public static void updateEmployeeAddress(string address)
        {
            OpenConection();
            try
            {
                if (address.Length <= 200)
                {
                    string addressQuery = "update employee_details set Address = '" + address + "' where employeee_id = '" + employeeID + "'";
                    SqlCommand cmd = new SqlCommand(addressQuery, sqlcon);
                    try
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Update successfully!");
                            EmpUpdateDetails.updateAddress = address;
                        }
                        else
                        {
                            EmpUpdateDetails.updateAddress = null;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Update unsuccessful!");
                    }
                }
                else
                { throw new Exception(); }
            }
            catch (Exception)
            { MessageBox.Show("Reached text limit!"); }
        }
    }
}





