using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            int summa = 0;

            Console.WriteLine("Haluan sinulta lukuja ");
            
            do
            {
                Console.WriteLine("Anna uusi luku");
                string line1 = Console.ReadLine();
                luku = int.Parse(line1);
                summa = summa + luku;
            }

            while (luku != 0);
            
            Console.WriteLine("Antamiesi lukujen summa on:" + summa);
        }
    }
}
    

