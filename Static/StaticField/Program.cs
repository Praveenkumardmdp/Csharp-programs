/*
Title : Static Field
Author : Praveen Kumar D
Created at : 06/10/2022
Updated at : 07/10/2022
Reviewed by :
Reviewed at :
*/

using System;
namespace StaticField
{
    public class BankAccount
    {
        public static int Count = 0;
        public int AccountNumber;
        public string AccountHolderName = "/0";
        //Value which is declared in Staic field 
        public static double RateofInterest = 0.18D;

        public void getAccountDetails(int AccountNumber,string AccountHolderName)
        {
            this.AccountHolderName=AccountHolderName;
            this.AccountNumber=AccountNumber;
            Count++;
        }
        public void displayAccountDetails()
        {
            Console.WriteLine("Account Number = "+AccountNumber);
            Console.WriteLine("Name = {0}",AccountHolderName);
            Console.WriteLine("RateofInterest = "+RateofInterest);
            Console.WriteLine();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            BankAccount.RateofInterest=10.5D;//Static field is Changeable
            BankAccount bankAccount1 = new BankAccount();
            bankAccount1.getAccountDetails(165432,"Praveen kumar");
            BankAccount bankAccount2 = new BankAccount();
            bankAccount2.getAccountDetails(153264,"Niswan");
            BankAccount bankAccount3 = new BankAccount();
            bankAccount3.getAccountDetails(123546,"Nehal");
            bankAccount1.displayAccountDetails();
            bankAccount2.displayAccountDetails();
            bankAccount3.displayAccountDetails();
            //Counting using the static field type.
            Console.WriteLine("Total No of Accounts = "+BankAccount.Count);
        }
    }
}