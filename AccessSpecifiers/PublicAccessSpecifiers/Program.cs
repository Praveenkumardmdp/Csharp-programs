/*
Title : PublicAccessSpecifiers
Author : Praveen Kumar D
Created at : 03/10/2022
Updated at : 10/10/2022
Reviewed by :
Reviewed at :
*/

using System;

namespace PublicAccessSpecifiers
{
    class Employee
    {
        public string Name = "Praveen Kumar";
        public void employeeDetail(string name)
        {
            Console.WriteLine("Hello! , I'm "+name);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee =new Employee();
            Console.WriteLine("Hi "+employee.Name);
            employee.employeeDetail("Dinesh kumar");
        }
    }
}