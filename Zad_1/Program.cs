using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PĘTLA WHILE
            // Program oblicza sumę 1+2+3+...+10

            int i = 1;
            int s = 0;

            while (i <= 10)
            {
                Console.WriteLine("Przebieg pętli nr: {0}", i);
                //s += i;
                //i++;
                s += i++;
            } 

            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
