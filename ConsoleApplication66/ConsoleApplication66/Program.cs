using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sportowiec> sportowcy = new List<Sportowiec>();
            sportowcy.Add(new Sportowiec("ssss", 4, 4555));
            sportowcy.Add(new Sportowiec("rrssss", 2, 455345));
            sportowcy.Add(new Sportowiec("erssss", 5, 34555));
            sportowcy.Sort();

        }
    }
}
