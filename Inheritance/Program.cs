using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Person[] people = new Person[3]
            {
            new Customer(){FirstName="Mustafa"},
            new Student(){FirstName = "Engin" },
            //difference between Interfaces and Inheritance
            //in inheritance we can "new" base class
            //interfaces can not be "new" ed
            new Person(){FirstName = "Salih"}
            };
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName); 
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    interface IPerson
    {

    }
    class Person2
    {

    }
    //class Customer : Person,Person2
    //only one base class can be uset not like interfaces
    class Customer : Person
    {
        public string City { get; set; }
    }
    // interfaces can be added after base class
    class Student : Person , IPerson
    {
        public string Department { get; set; }
    }
}
