/*
Title : Static Class
Author : Praveen Kumar D
Created at : 06/10/2022
Updated at : 07/10/2022
Reviewed by :
Reviewed at :
*/

using System;
namespace StaticClass
{
    public static class BasicMaths
    {
        public static float Pivalue = 3.14F;
        public static void ArithmeticCalculation(int FirstNumber,int SecondNumber)
        {
            Console.WriteLine("Addition of "+FirstNumber+" and "+SecondNumber+" = "+(FirstNumber+SecondNumber));
            Console.WriteLine("Subtraction of "+FirstNumber+" and "+SecondNumber+" = "+(FirstNumber-SecondNumber));
            Console.WriteLine("Multiplication of "+FirstNumber+" and "+SecondNumber+" = "+(FirstNumber*SecondNumber));
            Console.WriteLine("Division of "+FirstNumber+" and "+SecondNumber+" = "+(FirstNumber/SecondNumber));
            Console.WriteLine();
        }
        public static void square(int Number)
        {
            Console.WriteLine("Square of "+Number+" = "+(Number*Number));
            Console.WriteLine();
        }
        public static void cube(int Number)
        {
            Console.WriteLine("Cube of "+Number+" = "+(Number*Number*Number));
            Console.WriteLine();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Value pf PI = "+BasicMaths.Pivalue+"\n");
            BasicMaths.square(5);
            BasicMaths.cube(5);
            BasicMaths.ArithmeticCalculation(10,5);
        }
    }
}