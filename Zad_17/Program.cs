using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość liczby n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int j = 2;
            int s = 0;

            for (int i = 1; i <= n; i++)
            {
                s += j;
                j += 2;
                Console.WriteLine("S = {0,3}, j = {1,3}, i = {2,3}", s, j, i);
            }
            Console.ReadKey();
        }
    }
}
