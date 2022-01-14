using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jeśli wciszniesz przycisk 'n' zakończysz działanie programu. ");
            Console.WriteLine("Natomiast jeśli wciśniesz enter, program pokaże Ci godzinę poraz kolejny. \n");
            DateTime data = DateTime.Now;
            string n;
            do
            {
                Console.Write(data.ToString("hh:mm:ss"));
                n = Console.ReadLine();
            } while ( n != "n");
        }
    }
}
