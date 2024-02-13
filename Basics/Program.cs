using System;

namespace CSHARP
{
    class Program
    {
        public static void Main(string[] args)
        {   /**/
            ArithmeticOperations arithmeticOperations = new ArithmeticOperations();
            Console.WriteLine();
            arithmeticOperations.Addition(58645,5624);
            arithmeticOperations.Subtraction(5000,533);
            arithmeticOperations.Multiplication(10,2);
            arithmeticOperations.Division(5000,10);
            Console.WriteLine();
            
            Ifelseclass ifelseclass = new Ifelseclass();
            ifelseclass.checking(50,53);
            ifelseclass.checking(105,100);
            Console.WriteLine();
            
            Switchclass switchclass = new Switchclass();
            switchclass.Case(1);
            switchclass.Case(2);
            switchclass.Case(3);
            switchclass.Case(4);
            Console.WriteLine();
            
            ForloopClass forloopClass = new ForloopClass();
            forloopClass.MatrixPrint(3,3);
            Console.WriteLine();
            
            WhileloopClass whileloopClass =new WhileloopClass();
            whileloopClass.Whileloop(5);
            Console.WriteLine();

            DowhlieClass dowhlieClass =new DowhlieClass();
            dowhlieClass.Dowhlie(12);
            Console.WriteLine();
            
        }
    }
}