using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication70
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[2];
            try
            {
                table[1] = 2;
                throw new ArgumentNullException();
            }
            
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("poza zakresem");
            }
            catch
            {
                Console.WriteLine("inny wyjątek");
            }
            Console.ReadKey();
        }
    }
}
