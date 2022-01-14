using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PĘTLA FOR
            // Program oblicza sumę 1+2+3+...+10

            int s = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Przebieg pętli nr: {0}", i);
                s += i;
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
