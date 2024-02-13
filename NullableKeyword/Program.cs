/*
Title : NUllable Keyword
Author : Praveen Kumar D
Created at : 15/10/2022
Updated at : 17/10/2022
Reviewed by :
Reviewed at :
*/

using System;

namespace NullableKeyword
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Nullable<int> FatherAmount = 10000;
            Console.WriteLine(FatherAmount);
            
            Nullable<int> MyAmount = null;
            Console.WriteLine(MyAmount);

            int ? GrandFatherAmount = MyAmount ?? FatherAmount;
            Console.WriteLine(GrandFatherAmount);

            Console.WriteLine(MyAmount.GetValueOrDefault());
            Console.WriteLine(FatherAmount.GetValueOrDefault());
            Console.WriteLine(GrandFatherAmount.HasValue);
            Console.WriteLine(MyAmount.HasValue);

        }
    }
}