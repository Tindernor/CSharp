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
            if(b == 0)
            {
                Console.WriteLine("Darf nicht 0 seine!");
            }
            if(b != 0)
            {
                int ergebnis = a / b;
                Console.WriteLine(ergebnis);
            }
            Console.ReadLine();
        }
    }
}
