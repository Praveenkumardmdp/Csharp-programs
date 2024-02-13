using System;
namespace BaseKeyword
{
    public class Animal
    {
        public string Color = "Black and White";
        public string Height = "Medium";
    }
    public class Dog : Animal
    {
        public string Name ="Shimba";
        public string Height = "Tall";
        public string Color ="Brown";
        public void displayDetails()
        {
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("Color : "+Color);
            Console.WriteLine("Height : "+Height+"\n");
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("Color : "+base.Color);
            Console.WriteLine("Height : "+base.Height);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.displayDetails();
        }
    }
}