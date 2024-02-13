using System;
namespace CustomException
{
    public class MyException : Exception
    {
        public MyException()
        {

        }
        public MyException(string message) : base(message)
        {

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                throw new MyException("Its a Custom exception!");
            }
            catch(MyException exceptions)
            {
                Console.WriteLine(exceptions);
            }
        }
    }
}