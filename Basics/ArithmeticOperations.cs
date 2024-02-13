namespace CSHARP
{
    public class ArithmeticOperations
    {
        
            public void Addition(int number1,int number2)
            {
                Console.WriteLine("Addtion of "+number1+" and "+number2+" = "+(number1+number2));
            }
        
            public void Subtraction(int number1,int number2)
            {
                Console.WriteLine("Subtraction of "+number1+" and "+number2+" = "+ (number1-number2));
            }
        
            public void Multiplication(int number1,int number2)
            {
                Console.WriteLine("Multiplication of "+number1+" and "+number2+" = "+(number1*number2));
            }
            public void Division(int number1,int number2)
            {
                Console.WriteLine("Division of "+number1+" and "+number2+" = "+(number1/number2));
            }
    }
}