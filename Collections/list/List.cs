using System;
using System.Collections.Generic;

class List
{
    public static void Main(string[] args)
    {
        List<string> list = new List<string>();
        
        //Adding elements 
        Console.WriteLine("Menu list:");
        list.Add("Pizza");
        list.Add("Grill chicken");
        list.Add("Chicken soup");

        //printing elements in list
        foreach (var value in list)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();

        //Reverse a list
        list.Reverse();
        Console.WriteLine("Menu list:");
        foreach (var value in list)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();
        
        // removing element
        list.Remove("Pizza");
        Console.WriteLine("Menu list:");
        foreach (var value in list)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();
    }
}