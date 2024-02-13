using System;
namespace FunctionType
{
    class Program
    {
        public string display(string name)
        {
            string Greetings = "Hello! ";
            return Greetings+name;
        }
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(program.display("Praveen"));

        }
    }
}