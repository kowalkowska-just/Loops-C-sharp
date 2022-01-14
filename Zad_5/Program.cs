using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dlug = 80;
            int dziennyZarobekJanka = 50;
            int dziennyZarobekKarola = 40;
            int dzien = 0;
            int aktualnaSplata = 0;

            do
            {
                dzien++;
                aktualnaSplata += (int)(0.2 * dziennyZarobekJanka + 0.2 * dziennyZarobekKarola);
                Console.WriteLine("dzień nr: {0}, spłata łączna do tego dnia: {1}", dzien, aktualnaSplata);
            } while (aktualnaSplata < dlug);

            Console.ReadKey();
        }
    }
}
