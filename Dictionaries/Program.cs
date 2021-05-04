using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals.Add("Turkey", "Ankara");
            capitals.Add("Poland", "Warsaw");
            capitals.Add("Germany", "Berlin");
            capitals.Add("England", "London");

            Console.WriteLine("Capital : {0}", capitals["Poland"]);
            
        }
    }
}
