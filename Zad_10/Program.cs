using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość liczby h: ");
            int h = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", i*j);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
