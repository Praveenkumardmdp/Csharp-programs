using System;
namespace UserInput
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Enter your Age : ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Age);
            Console.WriteLine("Enter your Favourite Float Value : ");
            float FavouriteNumber = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(FavouriteNumber);
        }
    }
}