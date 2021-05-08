using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat =new AMevzuat();
            aMevzuat.Degerlendir();
            aMevzuat.Add();


        }
    }
    abstract class MevzuatBase
    {
        //abstract classes can have constructor
        protected MevzuatBase()
        {
            Console.WriteLine("Constuctor");
        }
        public abstract void Degerlendir();
        public void Add()
        {
            Console.WriteLine("Mevzuat Added");
        }
    }
    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A mevzuatina gore degerlendirildi");
        }
    }
    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B mevzuatina gore degerlendirildi");
        }
    }



    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }
}

