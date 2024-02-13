using System;
namespace PRIVATEKEYWORD
{
    class Employee
    {
        private string? Name;
        private double Salary;

        private void displayDetails()
        {
            Console.WriteLine($"Name : {0}\nSalary : {1}",Name,Salary);
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public string getName()
        {
            return Name;
        }
        public double salary
        {
            get {return Salary;}
            set { Salary = value;}
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.setName("Praveen kumar");
            employee.salary=10000;
            Console.WriteLine("Name : "+employee.getName());
            Console.WriteLine("Salary : "+employee.salary);
        }
    }
}