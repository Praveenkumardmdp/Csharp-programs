using System;
namespace Properties
{
    public class Employee
    {
        private string Name ;
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value ;
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.name = "Praveen kumar";
            Console.WriteLine(employee.name);
        }
    }
}