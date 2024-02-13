/*
Title : PrivateAccessSpecifiers
Author : Praveen Kumar D
Created at : 03/10/2022
Updated at : 10/10/2022
Reviewed by :
Reviewed at :
*/
using System;

namespace PrivateAccessSpecifiers
{
    class Program
    {
        public string Name = "Praveen kumar";
        private int Salary = 50000;
        private void employeedetail(string name)
        {
            Console.WriteLine("Hello I'm "+name);
            Console.WriteLine("Salary = "+Salary);
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            program.employeedetail("Prem kumar");
        }
    }
}