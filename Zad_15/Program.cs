using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_15
{
    internal class Program
    {

        static void SetRedTextAndYellowBackground()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
        }

        static void SetYellowTextAndRedBackround()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartość liczby n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
             
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                { 
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            SetRedTextAndYellowBackground();
                            Console.Write("X");
                        }
                        else
                        {
                            SetYellowTextAndRedBackround();
                            Console.Write("O");
                        }
                    } else
                    {
                        if (j % 2 == 0)
                        {
                            SetYellowTextAndRedBackround();
                            Console.Write("O");
                        }
                        else
                        {
                            SetRedTextAndYellowBackground();
                            Console.Write("X");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
