using System;
namespace TryCatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the value1 : ");
            int Value1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Value2 : ");
            int Value2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.Write("Divided Value : ");
                float Result = (float)(Value1/Value2);
                Console.WriteLine(Result);
            }
            catch(Exception dividedError)
            {
                Console.WriteLine(dividedError);
            }
            Console.Write("Addition of two Numbers : "+(Value1+Value2));

        }
    }
}