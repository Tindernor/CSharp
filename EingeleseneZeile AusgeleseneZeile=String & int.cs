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
            string eingeleseneZeile = Console.ReadLine();
            int gewandelteZeile;
            gewandelteZeile = Convert.ToInt32(eingeleseneZeile);
            Console.WriteLine(gewandelteZeile);
            Console.ReadLine();
        }
    }
}
