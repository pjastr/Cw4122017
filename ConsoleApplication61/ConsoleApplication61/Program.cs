﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication61
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new IndexOutOfRangeException();
            }
            catch
            {
                Console.WriteLine("błąd");
                throw new ArgumentNullException();
            }
            Console.ReadKey();
        }
    }
}
