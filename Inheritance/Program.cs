/*
Title :Single Inheritance
Author : Praveen Kumar D
Created at : 03/10/2022
Updated at : 05/10/2022
Reviewed by :
Reviewed at :
*/
using System;

namespace CSHARP
{
class Program
{
    public static void Main(string[] args)
    {
        //Single Inheritance
        Dog dog = new Dog();
        Console.WriteLine();
        dog.getName("Simbha");

        dog.displayName();
        Console.Write("Dog is ");
        dog.bark();
        Console.Write("Dog is ");
        dog.eat();
        Console.WriteLine();
    }
}
}