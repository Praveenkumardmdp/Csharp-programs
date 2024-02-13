using System;
namespace MethodOverriding
{
    public class SalaryCalculation
    {
        public virtual void salaryPaid(int Amount,int NumberOfMonths)
        {
            int Salary = Amount/NumberOfMonths;
            Console.WriteLine("The Salary Paid is "+Salary);
        }
    }
    public class NewSalaryCalculation : SalaryCalculation
    {
        public override void salaryPaid(int Amount,int NumberOfMonths)
        {
            double ProvidentFund = 0.18,Salary = (Amount/NumberOfMonths)-(Amount/NumberOfMonths)*ProvidentFund;
            Console.WriteLine("The Salary Paid is "+Salary);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            SalaryCalculation salaryCalculation = new SalaryCalculation();
            salaryCalculation.salaryPaid(400000,12);
        }
    }
}