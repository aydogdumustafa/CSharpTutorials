using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Hirka : IGiyin
    {
        public void Giyin()
        {
            Console.WriteLine("Hirka Giyildi");
        }
    }
}
