using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using InterfaceAbstractDemo.Adapters;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1990,1,1),FirstName = "Mustafa" , LastName = "Aydogdu", NationalityId = "123213213" });
            Console.ReadLine();
        }

    }
}
