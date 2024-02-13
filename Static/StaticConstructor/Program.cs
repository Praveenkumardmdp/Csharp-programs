/*
Title : Static Constructor
Author : Praveen Kumar D
Created at : 06/10/2022
Updated at : 07/10/2022
Reviewed by :
Reviewed at :
*/

using System;
namespace StaicConstructor
{
    public class Account
    {
        public int id;
        public string Name="/0";
        public static float RateofInterest;
        public Account(int id,string Name)
        {
            this.id=id;
            this.Name=Name;
        }
        static Account()
        {
            RateofInterest = 10.5F;
        }
        public void displayAccountDetail()
        {
            Console.WriteLine("\nAccount Id = "+id+"\nAccount Holder Name = "+Name+"\nRate of Interest = "+RateofInterest+"\n");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Account accountfirst = new Account(15326,"Praveen kumar.D");
            Account accountsecond = new Account(15327,"Prem kumar");

            accountfirst.displayAccountDetail();
            accountsecond.displayAccountDetail();
        }
    }
}