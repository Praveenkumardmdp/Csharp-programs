using System;
using System.Reflection;
namespace REFLECTION
{
    class Employee
    {
        public string Name = "Praveen kumar";
        public int Id = 125463;
        private double Salary = 500000;
        private void employeeDetail()
        {
            Console.WriteLine("Name = {0}\nId = {1}\nSalary = {3}",Name,Id,Salary);
        }
    }
    class Program
    {
        private static void Main(string[] args)
        {
            Employee employee = new Employee();
            //Accessing from class employees by creating object
            Console.WriteLine(employee.Id+" : "+employee.Name);
            Console.WriteLine();
            //Using Refelection;
            typeof(Employee).GetMethod("employeeDetail", BindingFlags.NonPublic | BindingFlags.Instance |BindingFlags.Static).Invoke(new Employee(),null);
        }
    }
    
}