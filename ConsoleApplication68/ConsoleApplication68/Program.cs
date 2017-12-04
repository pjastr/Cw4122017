using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbe");
            int a=-1;
            while(true)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a < 0) throw new ArgumentOutOfRangeException();
                    break;
                    
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Błędny format, podaj liczbę dodatnią");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("liczba ujemna, podaj liczbę dodatnią");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("liczba spoza zakresu zmiennej, podaj liczbę dodatnią");
                }   
                catch(Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
            Console.WriteLine("Pierwiastek= {0}", Math.Sqrt(a));
            Console.ReadLine();
        }
    }
}
