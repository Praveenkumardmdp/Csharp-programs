using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    class StudentName
    {
        public string? FirstName{get;set;}
        public string? LastName{get;set;}
        public int StudentId{get;set;}
    }
    public static void Main(string[] args)
    {
        var students= new Dictionary<int,StudentName>()
        {
            {1,new StudentName{FirstName="Praveen",LastName="kumar",StudentId=621}},
            {2,new StudentName{FirstName="Prem",LastName="kumar",StudentId=351}},
            {3,new StudentName{FirstName="Selva",LastName="Bharathi",StudentId=561}},
        };

        foreach (var index in Enumerable.Range(1,3))
        {
            Console.WriteLine("Student "+index+" is "+students[index].FirstName+" "+students[index].LastName+" and ID is "+students[index].StudentId);
        }
        Console.WriteLine();
    }
}