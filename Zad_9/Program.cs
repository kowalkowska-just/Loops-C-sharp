using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość liczby n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int suma = 0;
            int liczaNieparzysta;

            for (int i = 1; i <= n; i++)
            {
                liczaNieparzysta = 2 * i - 1;
                suma += liczaNieparzysta;

                if (i == n)
                {
                    Console.Write("{0} ", liczaNieparzysta);
                } else
                {
                    Console.Write("{0} + ", liczaNieparzysta);
                }
            }

            Console.Write("= {0}", suma);
            Console.ReadLine();
        }
    }
}
