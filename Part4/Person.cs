using System;

namespace Part4
{
    public class Person
    {
        // name, phone number and email address
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public Person()
        {
        }

        public Person(string name, int phoneNumber, string emailAddress)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }

        public override string ToString()
        {
            
            return $"Class name :{GetType().Name}\n" +
                   $"Person's name:{Name}\n" +
                   $"Email address:{EmailAddress}";
        }
    }
}