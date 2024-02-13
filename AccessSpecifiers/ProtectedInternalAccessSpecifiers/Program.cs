/*
Title : ProtectedInternalAccessSpecifiers
Author : Praveen Kumar D
Created at : 03/10/2022
Updated at : 10/10/2022
Reviewed by :
Reviewed at :
*/
using System;

namespace ProtectedInternalAccessSpecifiers
{
    class Employee
    {
        protected internal string Name = "Praveen";
        protected internal int Salary = 50000;
        protected internal void employeeDetails(string Role)
        {
            Console.WriteLine("Role = "+Role);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Name = "+employee.Name);
            Console.WriteLine("Salary = "+employee.Salary);
            employee.employeeDetails("Developer");
        }
    }
}