using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticke_varijable
{
    class PrvaKlasa
    {
        private static int counter = 0;

        public int Counter { get => counter; }

        static PrvaKlasa()
        {
            counter++;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa();
            PrvaKlasa y = new PrvaKlasa();
            PrvaKlasa z = new PrvaKlasa();

            Console.WriteLine(x.Counter);
            Console.WriteLine(y.Counter);
            Console.WriteLine(z.Counter);

            Console.ReadKey();
        }
    }
}