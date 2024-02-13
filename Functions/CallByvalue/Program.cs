using System;
namespace CallByvalue
{
    class Program
    {
        public void callbyvalue(int Value)
        {
            Value = Value*Value;
            Console.WriteLine("In call by value function : "+Value);
        }
        public static void Main(string[] args)
        {
            int Value =20;
            Program program = new Program();
            Console.WriteLine("Before Call by value : "+Value);
            program.callbyvalue(Value);
            Console.WriteLine("After the call by value : "+Value);
        }
    }
}