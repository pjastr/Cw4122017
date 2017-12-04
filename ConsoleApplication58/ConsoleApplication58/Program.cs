using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rower> rowery = new List<Rower>();
            rowery.Add(new Rower("sdsd", 4, 4545));
            rowery.Add(new Rower("dff", 4, 142545));
            rowery.Add(new Rower("uyyii", 4, 63));
            rowery.Sort();
            foreach(var element in rowery)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
