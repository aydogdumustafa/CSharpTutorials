using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id= 1 , FirstName="Mustafa",LastName ="Aydogdu", City = "Warszawa"};

            Customer customer2 = new Customer(2,"Emre","Aydogdu","Konya");

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ayse";
            customer3.LastName = "Aydogdu;";
            customer3.City = "Trabzon";

            Console.WriteLine(customer2.FirstName);
        }
       
    }

    class Customer
    {
        //default constructor
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
