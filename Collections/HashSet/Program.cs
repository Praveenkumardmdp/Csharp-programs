/*
Title : Hashset
Author : Praveen Kumar D
Created at : 05/01/2023
Updated at : 05/01/2023
Reviewed by :
Reviewed at :
*/
using System;
public class Program
{
    public static void Main(string[] args)
    {
        //Creating an integer type Hashset;
        HashSet<int> hashSet = new HashSet<int>();

        //Adding values to the hashset
        for(int Number=1;Number<=5;Number++)
        {
            hashSet.Add(Number*4);
        }

        //hashSet.Add(20);
        //hashSet.Add(21);
        
        //Printing the values in the set;
        foreach (int value in hashSet)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine();
    }
}