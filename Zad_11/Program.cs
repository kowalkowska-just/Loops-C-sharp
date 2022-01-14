using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość liczby n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Ilosc znakow w jednym wierszu wynosi n
            // Wierszy również jest n
            // s - ilość spacji, x - ilość "X"
            // s + x = n

            for (int i = 1; i <= n; i++)
            {
                // pętla rysująca spacje 
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // pętla rysująca "X"
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
