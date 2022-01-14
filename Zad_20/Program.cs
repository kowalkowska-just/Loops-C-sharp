using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = -10;
            int j = 2;
            int s = 0;

            while (i <= 10)
            {
                s = s + j;
                j = j + 2;
                Console.WriteLine("s = {0}, j = {1}, i = {2}", s, j, i);
                i++;
            }

            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
