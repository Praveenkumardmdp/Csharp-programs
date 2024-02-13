using System;
namespace Aggregation
{
    public class Address
    {
        public string DoorNumber;
        public string StreetName,City,District,State;
        public Address(string DoorNumber,string StreetName,string City,string District,string State)
        {
            this.DoorNumber=DoorNumber;
            this.StreetName=StreetName;
            this.City=City;
            this.District=District;
            this.State=State;
        }
    }
    public class Employee
    {
        public string Name;
        public int EmployeeId;
        public Address address;
        public Employee(string Name,int EmployeeId,Address address)
        {
            this.Name=Name;
            this.EmployeeId=EmployeeId;
            this.address=address;
        }
        public void displayEmployeeDetails()
        {
            Console.WriteLine("Name : "+Name+"("+EmployeeId+")");
            Console.WriteLine("Address \nDoor Number : "+address.DoorNumber+"\nStreet Name : "+address.StreetName+"\nCity :"+address.City+"\nDistrict : "+address.District+"\nState : "+address.State);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Address address = new Address("56/12","MiddleStreet","Palani","Dindigul","TamilNadu");
            Employee employee = new Employee("Praveen kumar",523465,address);
            employee.displayEmployeeDetails();
        }
    }
}