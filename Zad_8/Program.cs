using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile liczb podzielnych przez 7 chcesz wypisać:");
            int ile = Convert.ToInt32(Console.ReadLine());
            int liczbyPodzielne;

            for (int i = 0; i < ile; i++)
            {
                liczbyPodzielne = i * 7;
                if (i == ile - 1)
                {
                    Console.Write("{0}", liczbyPodzielne);
                } else
                {
                    Console.Write("{0},", liczbyPodzielne);
                }
            }

            Console.ReadLine();

        }
    }
}
