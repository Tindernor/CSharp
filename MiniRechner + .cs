using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int ergebnis;
            string rechenart = Console.ReadLine();
            if (rechenart == "+")
            {
                ergebnis = a + b;
                Console.WriteLine(ergebnis);

            }
            else if (rechenart == "-")
            {
                ergebnis = a - b;
                Console.WriteLine(ergebnis);

            }
            else
            {
                Console.WriteLine("Rechenart unbekannt!");

            }
            Console.ReadLine();
        }

    }
}
