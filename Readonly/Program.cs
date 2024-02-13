using System;
namespace Readonly
{
    public class Constant
    {
        public readonly int FatherAge;
        public readonly int SonAge;
        public readonly string FatherName="Durai";
        public readonly string SonName="Praveen kumar";
        public Constant(int FatherAge,int SonAge)
        {
            this.FatherAge=FatherAge;
            this.SonAge=SonAge;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Constant constant = new Constant(50,23);
            Console.WriteLine(constant.FatherName+" = "+constant.FatherAge);
            Console.WriteLine(constant.SonName+" = "+constant.SonAge);
        }
    }
}