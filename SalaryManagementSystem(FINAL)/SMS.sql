--create database SMS

--create table Employee_Details(
--Employeee_ID int identity primary key,
--Name varchar(60),
--CNIC varchar(15),
--Date_Of_Birth varchar(10),
--Email varchar(15),
--Contact_No varchar(13),
--Address varchar(200),
--Date_joined varchar(10)
--)

--create table salary_details(
--foreign key (Employeee_ID) references Employee_Details(Employeee_ID), 
--Employeee_ID int not null,
--Designation varchar(200),
--Full_Days int,
--Half_Days int,
--Leave_Days int,
--Work_Hours int,
--Allowance int,
--Basic_salary int,
--Gross_pay int,
--Income_Tax int,
--Net_pay int,
--Performance varchar(100)
--)

--insert into Employee_Details values ('Asma','123-456879075-8','23-78-7070','asma@gmail.com','0342-8776543','jbhjkhgkhhkh','56-89-9090')
--insert into Employee_Details values ('sadia','123-456879075-8','23-78-7070','asma@gmail.com','0342-8776543','jbhjkhgkhhkh','56-89-9090')
----drop table Employee_Details
--select * from Employee_Details
--select * from salary_details 
----drop database  SMS
----delete  from  salary_details where salary_details.Employeee_ID = '12'  
----delete from Employee_Details where Employee_Details.Employeee_ID = '12'
----select *  from Employee_Details where  Name like  'Asma Shaheen'
--select * from Employee_Details join salary_details on salary_details.Employeee_ID = Employee_Details.Employeee_ID

--create table Employee_Login(
--Employee_ID int primary key,
--Employee_Password varchar(10))
--alter table employee_login
--add foreign key (Employee_ID) REFERENCES employee_details(Employeee_ID);

--insert into Employee_Login values((SELECT IDENT_CURRENT('Employee_Details')), 'klms451')

--select * from employee_login

--create table Accountant(
--username varchar(10) primary key,
--password varchar(8),)
--insert into Accountant values('admin', 'admin123')
--select * from accountant 

--delete  from Employee_Details where Employeee_ID = '1'

--select * from Employee_Details where  Employeee_ID like '11' 
--select * from salary_details  where  Employeee_ID like '11'

--truncate table Employee_Details

--select * from Accountant


