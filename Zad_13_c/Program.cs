using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_13_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Do while
            // Program oblicza wartość y = ax + b 
            // Dla x = < -10 ; 10 >
            // Wartość a i b jest wprowadzana przez użytkownika

            Console.WriteLine("Podaj wartość liczby a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj wartość liczby b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int y;
            int x = -10;

            do 
            {
                y = a * x + b;
                Console.WriteLine("x = {0,8}, y = {1,8}", x, y);
                x++;
            } while (x<=10);

            Console.ReadKey();
        }
    }
}
