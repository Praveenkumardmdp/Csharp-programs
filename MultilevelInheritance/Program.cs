/*
Title :Multilevel Inheritance
Author : Praveen Kumar D
Created at : 03/10/2022
Updated at : 10/10/2022
Reviewed by :
Reviewed at :
*/
using System;

namespace MultilevelInheritance
{
    public class Employee
    {
        private int Salary;
        public string Name = "/0";
        public string Location = "Chennai Branch";
        private string Stream = "/0";

        public void employeeDetail(int salary,string stream,string name)
        {
            Salary = salary;
            Stream = stream;
            Name = name;
        }
        
        public void displayEmployeeDetail()
        {
            Console.WriteLine("Salary = "+Salary);
            Console.WriteLine("Stream = "+Stream);
        }

    }

    public class TestingEmployee : Employee
    {
        private string TestingRole = "/0";

        public void testingDetails(string testingRole)
        {
            TestingRole = testingRole;
        }

        public string displaytestingDetails()
        {
            return TestingRole;
        }
    }
    public class Developer : Employee
    {
        private string ProjectName = "/0";

        public void developerDetails(string projectname)
        {
            ProjectName = projectname;
        }

        public void displayProjectName()
        {
            Console.WriteLine("ProjectName = "+ProjectName);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            //Developer Class
            Developer developer = new Developer();

            developer.employeeDetail(20000,"Dotnet","Praveen Kumar");
            developer.developerDetails("Snapchat Application");

            Console.WriteLine("Developer Details : ");
            Console.WriteLine("Name = "+developer.Name);

            developer.displayEmployeeDetail();

            Console.WriteLine("Location = "+developer.Location);

            developer.displayProjectName();
            Console.WriteLine();

            //Testing class
            TestingEmployee testingEmployee = new TestingEmployee();
            
            testingEmployee.employeeDetail(15000,"Dot net","Prem kumar");
            testingEmployee.testingDetails("Filter Screen");

            Console.WriteLine("Testing Employee Details :");
            Console.WriteLine("Name = "+testingEmployee.Name);
            testingEmployee.displayEmployeeDetail();
            Console.WriteLine("Location = "+testingEmployee.Location);
            Console.WriteLine("Role = "+testingEmployee.displaytestingDetails());

            Console.WriteLine();
            //MULTILEVEL INHERITANCE

            /*ICICIbank icicibank = new ICICIbank();

            Console.WriteLine();
            icicibank.BalanceInfo();
            icicibank.transfer(5000);
            Console.WriteLine();
            icicibank.ICICbankDetails();*/
        }
    }
}