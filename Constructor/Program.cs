/*
Title : Constructor
Author : Praveen Kumar D
Created at : 09/10/2022
Updated at : 10/10/2022
Reviewed by :
Reviewed at :
*/
using System;
namespace Constructor
{
    /*public class Employee
    {
        public int EmployeeId ;
        public string Name = "/0";
        public int Salary;
        public void GetDetails(int employeeId,string name,int salary)
        {
            EmployeeId =employeeId;
            Name = name;
            Salary = salary;
        }
        public void displayDetails()
        {
            Console.WriteLine("\nID number "+EmployeeId+"-"+Name+" is Paid "+Salary+"\n");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.GetDetails(65321,"Praveen kumar",400000);
            employee.displayDetails(); 
        }
    }*/ 
   public class Employee  
    {  
        public Employee()  
        {  
            Console.WriteLine("Constructor Invoked");  
        }  
        ~Employee()  
        {  
            Console.WriteLine("Destructor Invoked");  
        }  
    }  
   class TestEmployee{  
       public static void Main(string[] args)  
        {  
            Employee e1 = new Employee();  
            Employee e2 = new Employee();  
        }  
    }  
}