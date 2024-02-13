/*
Title : this Keyword
Author : Praveen Kumar D
Created at : 03/10/2022
Updated at : 04/10/2022
Reviewed by :
Reviewed at :
*/

using System;
namespace ThisKeyword
{
    public class Expense
    {
        public int NumberofMembers;
        public int TotalSalary;
        public int MonthlyExpense;
        public void getExpenseDetails(int NumberofMembers,int TotalSalary,int MonthlyExpense)
        {
            this.NumberofMembers=NumberofMembers;
            this.TotalSalary=TotalSalary;
            this.MonthlyExpense=MonthlyExpense;
        }
        public void displayExpenseDetails()
        {
            Console.WriteLine("\nTotaly "+NumberofMembers+" Members spent Rupees."+MonthlyExpense+" Outof Rupees."+TotalSalary+".\n");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Expense expense = new Expense();
            expense.getExpenseDetails(5,800000,50000);
            expense.displayExpenseDetails();
        }
    }
}