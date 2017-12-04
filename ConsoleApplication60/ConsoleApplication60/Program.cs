using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication60
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[2];
            try 
            {
                table[25] = 2;
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("inny wyjątek");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("poza zakresem");
            }
            
            Console.ReadKey();
            
        }
    }
}
