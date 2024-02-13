//SINGLE INHERITANCE

namespace CSHARP
{
    public class Animal
    {
        protected string Name = "/0";

        public void getName(string name)
        {
            Name = name;
        }
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
        public void displayName()
        {
            Console.WriteLine("Name of the Dog is "+Name);
        }
    }
    public class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking...");
        }
    }
}