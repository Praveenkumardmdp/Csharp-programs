using System;
namespace CallByRefernce
{
    public class Reference
    {
        public void callByrefernce(ref int Value)
        {
            Value = Value * Value;
            Console.WriteLine("In Call by Reference function : "+Value);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int Value = 10;
            Reference reference = new Reference();
            Console.WriteLine("Before the Call by Reference : "+Value);
            reference.callByrefernce(ref Value);
            Console.WriteLine("After the Call by Reference : "+Value);
        }
    }
}