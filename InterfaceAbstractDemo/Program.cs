using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1990,1,1),FirstName = "Mustafa" , LastName = "Aydogdu", NationalityId = "123213213" });
        }

    }
}
