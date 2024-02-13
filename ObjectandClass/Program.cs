using System;

namespace ObjectandClass
{
    public class Square
    {
        public int side ;
        public int Area()
        {
            return side*side;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Square square =new Square();
            square.side=6;
            Console.WriteLine("\nArea of the Square : "+square.Area()+"\n");
        }
    }
}