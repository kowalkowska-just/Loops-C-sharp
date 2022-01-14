using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program pobiera od użytkownika dwie liczby: a i b
            // Oraz wypisuje wartości parzyste liczb znajdujących się pomiędzy przedziałem <a;b>

            Console.WriteLine("Podaj wartość a: ");
            int a = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Podaj wartość b: ");
            int b = Convert.ToInt32(Console.ReadLine());


            // Jeżeli a > b to zamien wartości

            if (a > b)
            {
                (a, b) = (b, a);
            }

            for (int i = a; i <= b; i++)
            {
                if (i%2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.ReadKey();
        }
    }
}
