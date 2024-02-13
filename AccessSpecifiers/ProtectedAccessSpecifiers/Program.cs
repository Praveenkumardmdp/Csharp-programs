/*
Title : ProtectedAccessSpecifiers
Author : Praveen Kumar D
Created at : 03/10/2022
Updated at : 10/10/2022
Reviewed by :
Reviewed at :
*/
using System;

namespace ProtectedAccessSpecifiers
{
    class Sportsmen
    {
        protected string Name = "Naveen";
        protected string Sports = "Cricket";

        protected void SportsmenDetail(int matchesPlayed)
        {
            Console.WriteLine("Total matches Played is "+matchesPlayed);
        }
    }
    class Program : Sportsmen
    {
        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.Name);
            Console.WriteLine(program.Sports);
            program.SportsmenDetail(120);

        }
    }
}