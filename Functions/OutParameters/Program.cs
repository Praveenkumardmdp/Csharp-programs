using System;
namespace OutParameter
{
    class Program
    {
        public void OutParameter(out int Value)
        {
            int Square = 2;
            Value = Square;
            Value = Value * Value;
            Console.WriteLine("In Out Parameter Function : "+Value);
        }
        public static void Main(string[] args)
        {
            int Value = 3;
            Program program = new Program();
            Console.WriteLine("Before the pass of Out Parameter : "+Value);
            program.OutParameter(out Value);
            Console.WriteLine("After the pass of Out Parameter : "+Value);
        }
    }
}