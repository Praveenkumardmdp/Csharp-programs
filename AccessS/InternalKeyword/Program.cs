using System;
namespace INTERNALKEYWORD
{
    class Student
    {
        internal string? Name;
        internal int Id;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.Name="Praveen kumar";
            student.Id=1003;
            Console.WriteLine("Name : "+student.Name);
            Console.WriteLine("ID : "+student.Id);
            
            NEWINTERNAL.Test test = new NEWINTERNAL.Test();
            test.testing();
        }
    }
}
namespace NEWINTERNAL
{
    class Test
    {
        public void testing()
        {
            INTERNALKEYWORD.Student student = new INTERNALKEYWORD.Student();
            student.Name="Kavin";
            student.Id=1325;
            Console.WriteLine("Name : "+student.Name);
            Console.WriteLine("ID : "+student.Id);
        }
    }
}