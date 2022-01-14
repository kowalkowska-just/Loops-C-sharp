using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość liczby a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj wartość liczby b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            loop:

            int R = a % b;

            if (a % b == 0)
            {
                Console.WriteLine(b);
            } else
            {
                a = b;
                b = R;
                Console.WriteLine("a= {0}, b= {1}, r= {2}", a, b, R);
                goto loop;
            }
            Console.ReadKey();
            
        }
    }
}
