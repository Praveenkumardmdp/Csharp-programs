using System;
namespace ReadonlyProperties
{
    public class Account
    {
        private string Name;
        private int AccountNumber;
        private static int counter=0;
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public int accountNumber
        {
            get
            {
                return AccountNumber;
            }
            set
            {
                AccountNumber = value;
            }
        }
        public Account()
        {
            counter++;
        }
        public static int Counter
        {
            get
            {
                return counter;
            }
        }
        public void displayDetails()
        {
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("Account Number : "+AccountNumber);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Account firstAccount = new Account();
            firstAccount.name="Durai";
            firstAccount.accountNumber=453265;
            Account secondAccount = new Account();
            secondAccount.name="Praveen kumar";
            secondAccount.accountNumber=453266;

            firstAccount.displayDetails();
            secondAccount.displayDetails();

            Console.WriteLine("Total no of Accounts : "+Account.Counter);
        }
    }
}