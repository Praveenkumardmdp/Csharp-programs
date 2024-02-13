using System;

class AreaCalculation
{
    public static double piValue;
    static AreaCalculation()
    {
        piValue=3.14159D;
        Console.WriteLine("PiValue is invoked");
    }
    public static void Main(string[] args)
    {
        Calculation calculation = new Calculation();
        calculation.squareArea(5);
        Calculation calculation1 =new Calculation();
        calculation1.circleArea(6);
    }
}
class Calculation : AreaCalculation
{
    public void squareArea(int side)
    {
        Console.WriteLine("Area of the squrae = "+(side*side));
    }
    public void circleArea(int radius)
    {
        Console.WriteLine("Area of the circle = "+(piValue*(radius*radius)));
    }
}