using System;

public class Program
{
    public static void Main(string[] args)
    {
        int Min=1000;
        int Max=9999;
        Random random = new Random();
        Console.WriteLine(random.Next(Min,Max));
    }
}