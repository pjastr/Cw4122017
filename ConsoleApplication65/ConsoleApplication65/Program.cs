using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication65
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbe");
            try
            {
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(a));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
