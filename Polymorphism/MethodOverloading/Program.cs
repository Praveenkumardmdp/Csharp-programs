using System;
namespace MethodOverloading
{
    public class SalaryCalculation
    {
        public string Name = "/0";
        public void salaryPaid(int Amount,int NumberOfMonths)
        {
            double Salary = Amount/NumberOfMonths;
            Console.WriteLine("Total Salary for "+Name+" paid is "+Salary);
        }
        public void salaryPaid(int Amount,double GST,int NumberOfMonths)
        {
            double ProvidentFund = (Amount/NumberOfMonths)*GST;
            Console.WriteLine("PensionFee for "+Name+" is "+ProvidentFund);
        }
        public void salaryPaid()
        {
            Console.WriteLine("The Salary will be Paid later!");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            SalaryCalculation salaryCalculation = new SalaryCalculation();
            salaryCalculation.Name = "Praveen kumar";
            Console.WriteLine();
            salaryCalculation.salaryPaid(400000,12);
            salaryCalculation.salaryPaid(400000,0.18,12);
            salaryCalculation.salaryPaid();
            Console.WriteLine();
        }
    }
}