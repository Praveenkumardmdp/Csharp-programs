using System;
namespace Finally
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
            catch (Exception divide)
            {
                Console.WriteLine(divide);
            }
            finally
            {
                Console.WriteLine("Addition of two Number : "+(Value1+Value2));
            }
        }
    }
}