using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Ceket : IGiyin
    {
        public void Giyin()
        {
            Console.WriteLine("Ceket Giyildi");
        }
    }
}
