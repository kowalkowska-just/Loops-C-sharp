using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program oblicz sumę 11 początkowych liczb parzystych
            int i = 1;
            int j = 2;
            int s = 0;

            while(i <= 10)
            {
                s = s + j;
                j = j + 2;
                i++;

                Console.WriteLine("S = {0}, j = {1}, i = {2}", s, j, i);
            }

            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
