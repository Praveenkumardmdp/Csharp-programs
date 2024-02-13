/*
Title : Type Casting
Author : Praveen Kumar D
Created at : 27/09/2022
Updated at : 27/09/2022
Reviewed by :
Reviewed at :
*/
using System;
namespace TypeCasting
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Implicit TypeCasting
            int Number = 100;
            double newNumber = Number;
            Console.WriteLine(newNumber);

            //Explicit TypeCasting
            float number = 21.6F;
            int newnumber = (int)number ;
            Console.WriteLine(newnumber);

        }
    }
}