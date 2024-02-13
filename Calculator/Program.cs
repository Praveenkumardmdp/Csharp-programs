/*
Title : Calculator
Author : Praveen Kumar D
Created at : 21/10/2022
Updated at : 21/10/2022
Reviewed by :
Reviewed at :
*/
using System;
namespace Calculator
{
    public static class ArithmeticOperations
    {
        public static double Addition(double Number1)
        {
            Console.Write("Enter the Second Number : ");
            double Number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Number1+Number2);
            return Number1+Number2;
        }
        public static double Subtraction(double Number1)
        {
            Console.Write("Enter the Second Number : ");
            double Number2 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Number1-Number2);
            return Number1-Number2;
        }
        public static double Multiplication(double Number1)
        {
            Console.Write("Enter the Second Number : ");
            double Number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Number1*Number2);
            return Number1*Number2;
        }
        public static double Division(double Number1)
        {
            Console.Write("Enter the second Number : ");
            double Number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Number1/Number2);
            double divideResult = Number1/Number2;
            return divideResult;
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Double Result;
            Console.WriteLine("Entering the Calculator");
            while (true)
            {
                char Continue ;
                Console.Write("Enter the first Number : ");
                Result= Convert.ToDouble(Console.ReadLine());
                do
                {
                    Console.Write("Enter the Operator : ");
                    char Operator = Convert.ToChar(Console.ReadLine());
                    switch (Operator)
                    {
                        case '+':
                            Result = ArithmeticOperations.Addition(Result);
                            break;
                        case '-':
                            Result = ArithmeticOperations.Subtraction(Result);
                            break;
                        case '*':
                            Result = ArithmeticOperations.Multiplication(Result);
                            break;
                        case '/':
                            Result = ArithmeticOperations.Division(Result);
                            break;
                        default:
                            Console.WriteLine("The Operation you have enter is Invalid!");
                            break;
                    }
                    Console.Write("Press C to Continue : ");
                    Continue = Convert.ToChar(Console.ReadLine());
                }while(Continue == 'c' || Continue == 'C');
            }
        }
    }
}