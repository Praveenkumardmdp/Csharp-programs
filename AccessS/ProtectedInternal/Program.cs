using System;
namespace PROTECTEDINTERNAL
{
    public class Student
    {
        protected internal string? Name;
        protected internal int Id;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.Name="Niswan";
            student.Id=1523;
            Console.WriteLine("Name : "+student.Name);
            Console.WriteLine("ID : "+student.Id);
        }
    }
}