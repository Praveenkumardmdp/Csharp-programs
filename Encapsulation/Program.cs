/*
Title : Encapsulation
Author : Praveen Kumar D
Created at : 03/10/2022
Updated at : 10/10/2022
Reviewed by :
Reviewed at :
*/
using System;
namespace Encapsulation
{
    class Employee
    {
        public string Name = "/0";
        public int Amount;
        public int NumberOfMonths;
        private double ProvidentFund=0.18;
        public double GetSalary()
        {
            return Amount/NumberOfMonths-(Amount/NumberOfMonths)*ProvidentFund;
        }
        public void displayEmployeeDetails()
        {
            Console.WriteLine("Name of the Employee : "+Name);
            Console.WriteLine("Total Amount Paid : "+Amount);
            Console.WriteLine("Number of Days Worked : "+NumberOfMonths);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Employee employee = new Employee();
            employee.Name="Praveen Kumar D";
            employee.Amount=360000;
            employee.NumberOfMonths=12;
            employee.displayEmployeeDetails();
            Console.WriteLine("Salary Paid after dedution of PF : "+employee.GetSalary());
            Console.WriteLine();
        }
    }
}