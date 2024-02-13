class ConstructorDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Main method is called");
        ConstructorDemo constructorDemo = new ConstructorDemo();
    }
    static ConstructorDemo()
    {
        Console.WriteLine("Static constructor is invoked");
    }
    public ConstructorDemo()
    {
        Console.WriteLine("Non Static constructor is invoked");
    }
}