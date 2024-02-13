/*
Title : Exception Handling
Author : Praveen Kumar D
Created at : 05/01/2023
Updated at : 05/01/2023
Reviewed by :
Reviewed at :
*/

using System;
namespace ExceptionHandle
{
    public class Program
    {
        //customexception for our own new exceptions:
        public class CustomException : Exception
        {
            public CustomException()
            {

            }
            public CustomException(string message) : base(message)
            {

            }
        }
        public static void Main(string[] args)
        {
            //Try block is where the code is written for exceution
            try
            {
                Console.WriteLine("Enter the two Numbers to do Calculations!");
                float firstNumber= (float)Convert.ToDouble(Console.ReadLine());
                float secondNumber=(float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nRESULTS:\n");
                Console.Write("Addition : ");
                float firstResult = firstNumber+secondNumber;
                Console.WriteLine(firstResult);

                //throw can be used raise an exception manually:
                if(firstNumber == 0)
                {
                    throw new CustomException("First Number Cannot be zero!");
                }
                Console.Write("Subtraction : ");
                float secondResult = firstNumber-secondNumber;
                Console.WriteLine(secondResult);

                Console.Write("Multiplication : ");
                float thirdResult = firstNumber*secondNumber;
                Console.WriteLine(thirdResult);

                //throw can be used raise an exception manually:
                if(secondNumber == 0)
                {
                    throw new DivideByZeroException();
                }

                Console.Write("Divition : ");
                float fourthResult = firstNumber/secondNumber;
                Console.WriteLine(fourthResult);
            }
            //Catch block is used to catch an exception that has been occcured
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by Zero");
            }
            //Catch block for the custom exceptions:
            catch(CustomException customExceptions)
            {
                Console.WriteLine(customExceptions.Message);
            }
            catch(Exception otherExceptions)
            {
                Console.WriteLine(otherExceptions.GetType()+" : "+otherExceptions.Message);
            }
            //finally block is used for excueting a specific codes even after having an exceotion
            finally
            {
                Console.WriteLine("Thank you for using my application!\n");
            }
        }
    }
}