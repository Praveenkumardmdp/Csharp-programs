using System;
using System.Collections.Generic;

public class BankName
{
    public static void Main(string[] args)
    {
        Console.WriteLine("....Welcome to Aspire bank!....");
        Bank bank = new Bank();
        bank.transaction();
    }
}
public class Bank
{
    public void transaction()
    {
        HashSet<Account> set = new HashSet<Account>();
        int choice;
        while(true)
        {
            try
            {
                Console.WriteLine("------Choose the Transaction------");
                Console.WriteLine("1.Open New Account");
                Console.WriteLine("2.Deposit Amount");
                Console.WriteLine("3.Withdraw Amount");
                Console.WriteLine("4.Account details");
                Console.WriteLine("5.Exit\n");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Enter the Choice :\n");
                choice = Convert.ToInt32(Console.ReadLine());
                //Checking choice is valid or not;
                    switch (choice)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            Console.WriteLine("Thanks for visiting us!...");
                            return;
                        default:
                            Console.WriteLine("Invalid option!..Please Enter the correct Choice");
                            break;
                    }
            }
            catch
            {

            }
        }
    }
}
public class AccountCreation
{
    public Account accountCreation()
    {
        string firstName,lastName,age,phoneNumber,balance;
        Boolean checkException = false;
        try
        {
            Account account = new Account();
            account.generateAccountNumber();
            Console.WriteLine("Enter First name : ");
            firstName=Console.ReadLine();
        }
        catch
        {

        }
        return null;
    }
}