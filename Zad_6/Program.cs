using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program rysujacy kwadrat z "*" 
            // Liczbe wierszy oraz kolumn = n
            // Liczbe n podaje użytkownik

            Console.WriteLine("Podaj wartość n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
