namespace CSHARP
{
    public class Switchclass
    {
        public void Case(int Number)
        {
            switch(Number)
            {
                case 1:
                Console.WriteLine("Addition");
                break;

                case 2:
                Console.WriteLine("Subtraction");
                break;

                case 3:
                Console.WriteLine("Multiplication");
                break;

                case 4:
                Console.WriteLine("Division");
                break;
            }
        }
    }
}