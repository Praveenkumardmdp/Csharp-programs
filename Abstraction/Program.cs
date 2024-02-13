/*
Title : Abstraction
Author : Praveen Kumar D
Created at : 03/10/2022
Updated at : 10/10/2022
Reviewed by :
Reviewed at :
*/

using System;
namespace Abstraction
{
    abstract class Shape
    {
        public abstract double area();
        public double Pi_value = 3.14;
    }
    class Square : Shape
    {
        private int Side;
        public Square(int side)
        {
            Side=side;
        }
        public override double area()
        {
            Console.WriteLine("Area of Square : ");
            return Side*Side;
        }
    }
    class Circle : Shape
    {
        private int Radius;
        public Circle(int radius)
        {
            Radius =radius;
        }
        public override double area()
        {
            Console.WriteLine("Area of Circle : ");
            return Pi_value*Radius*Radius;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Shape shape;
            shape = new Square(6);
            double SquareArea = shape.area();
            Console.WriteLine(SquareArea);
            shape = new Circle(6);
            double CircleArea = shape.area();
            Console.WriteLine(CircleArea);
            
            
        }
    }
}