using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SalaryManagementSystem;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        SalaryManagementSystem.SalaryCalculation obj = new SalaryManagementSystem.SalaryCalculation();
       [TestMethod]
        public void Days_Test()
        {
            double fulldays = 18;
            double halfdays = 2;
            double expected = 152;
            double actual = obj.days(fulldays, halfdays);
            Assert.AreEqual(expected, actual, "Operation failed to complete!");
        }
        [TestMethod]
        public void WorkingDays_Test() 
        {
            double workdays = 20;
            double expected = 10000;
            double actual = obj.workingdays(workdays);
            Assert.AreEqual(expected, actual, "Operation failed to complete!");
        }

        [TestMethod]
        public void Allowance_test() 
        {
            double Basic_Salary = 80000;
            double expected_grosspay = 8000;
            double actual = obj.allowance(Basic_Salary);
            Assert.AreEqual(expected_grosspay, actual, "Operation failed to complete!");  

        }
        [TestMethod]
        public void Gross_Pay_Test() 
        {
            double allowance = 10000;
            double Basic_salary = 80000;
            double expected = 90000;
            double actual = obj.grosspay(allowance, Basic_salary);
            Assert.AreEqual(expected, actual, "Operation failed to complete!");
        }
        [TestMethod]
        public void Incometax() 
        {
            double Basic_Salary = 80000;
            double grosspay = 10000;
            double expected = 300;
            double actual = obj.Incometax(Basic_Salary,grosspay);
            Assert.AreEqual(expected, actual, "Operation failed to complete!");
            
        }
        [TestMethod]
        public void net_Salary_Test() 
        {
            double Basic = 50000;
            double income = 10000;
            double expected = 40000;
            double actual = obj.netsalary(Basic,income);
            Assert.AreEqual(expected, actual, "Operation failed to complete!");
        }

        [TestMethod]
        public void Performance_Test()
        {
            double workhours = 130;
            string expected = "50%";
            string actual = obj.performance(workhours);
            Assert.AreEqual(expected, actual, "Operation failed to complete!");
        }

    }
}
