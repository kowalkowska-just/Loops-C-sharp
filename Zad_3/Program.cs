using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PĘTLA FOR z wartością n wczytywaną z klawiatury
            // Program oblicza sumę 1+2+3+...+n

            Console.WriteLine("Podaj wartość n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int s = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Przebieg pętli nr: {0}", i);
                s += i;
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
