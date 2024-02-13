using System;
namespace PROTECTEDKEYWORD
{
    class Student
    {
        public string? Name;
        protected double Grade;
        protected int Id;
    }
    class Program:Student
    {
        private static void Main(string[] args)
        {
            Program program = new Program();
            program.Name="Praveen kumar";
            program.Id=136254;
            program.Grade=7.20;

            Student student = new Student();
            //student.Name = "King";
            //Console.WriteLine("Grade : "+student.Id);
            //Console.WriteLine("Grade : "+student.Grade);
            Console.WriteLine("Grade : "+program.Name);
            Console.WriteLine("Grade : "+program.Id);
            Console.WriteLine("Grade : "+program.Grade);
        }
    }
}
namespace NewPROTECTEDKEYWORD
{
    class NewStudent
    {
        public void Details()
        {
            PROTECTEDKEYWORD.Student student = new PROTECTEDKEYWORD.Student();
            //student.
        }
    }
}