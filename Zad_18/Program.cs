using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int j = 2;

            for (int i = 1; i <= 30; i++)
            {
                s += j;
                j += 2;
                Console.WriteLine("S = {0,3}, j = {1,3}, i = {2,3}", s, j, i);
            }
            Console.WriteLine("Zaoszczędził w ten sposób {0} zł.", s);
            Console.ReadKey();
        }
    }
}
