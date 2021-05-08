using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            

            //IPersonManager employeeManager = new EmployeeManager();
            
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());


        }
    }
    //class PersonManager
    //{
    //    //implemented operation
    //    public void Add()
    //    {
    //        Console.WriteLine("Eklendi");
    //    }
    //}
    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();


    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }
    }
    //class inherits ---------------- interface implements

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee Added");
        }

        public void Update()
        {
            Console.WriteLine("Employee Updated");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern Added");
        }

        public void Update()
        {
            Console.WriteLine("Intern Updated");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
      
    }
    

    class Person
    {

    }
    class Customer : Person
    {

    }
}
