using System;
namespace PUBLICKEYWORD
{
    class Point
    {
        public int FirstValue;
        public int SecondValue;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Point point = new Point();
            point.FirstValue = 10;
            point.SecondValue = 20;

            Console.WriteLine("Final Value : "+(point.FirstValue+point.SecondValue));
            NewPUBLICKEYWORD.newClass newClass = new NewPUBLICKEYWORD.newClass();
            newClass.Testing();
        }
    }
}
namespace NewPUBLICKEYWORD
{
    class newClass
    {
        public void Testing()
        {
            PUBLICKEYWORD.Point point = new PUBLICKEYWORD.Point();
            point.FirstValue = 20;
            point.SecondValue =60;
            Console.WriteLine("First value = "+point.FirstValue+"\nSecond value : "+point.SecondValue);
        }
    }
}