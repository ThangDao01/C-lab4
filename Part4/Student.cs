using System;
namespace Part4
{
    public class Student : Person
    {
        public string Program  { get; set; }

        public Student()
        {
        }

        public Student(string program)
        {
            Program = program;
        }

        public Student(string name, int phoneNumber, string emailAddress, string program) : base(name, phoneNumber, emailAddress)
        {
            Program = program;
        }
    }
}