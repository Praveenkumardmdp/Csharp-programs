/*
Title : InternalAccessSpecifiers
Author : Praveen Kumar D
Created at : 03/10/2022
Updated at : 10/10/2022
Reviewed by :
Reviewed at :
*/
using System;

namespace InternalAccessSpecifiers
{
    class Sportsmen
    {
        internal string Name = "Pradeep";
        internal string Sports = "Football";
        internal void SportsmenDetail(int Matchesplayed)
        {
            Console.WriteLine("Matches Played is "+Matchesplayed);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Sportsmen sportsmen = new Sportsmen();
            Console.WriteLine("Name = "+sportsmen.Name);
            Console.WriteLine("Sports = "+sportsmen.Sports);
            sportsmen.SportsmenDetail(50);
        }
    }
}