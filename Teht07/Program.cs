using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;
            Console.WriteLine("Anna minulle jokin vuosiluku, niin kerron onko se karkausvuosi: ");   // Kysytään vuosi
            string line = Console.ReadLine();
            vuosi = int.Parse(line);

            int karkaus = vuosi % 4;    // Karkausvuosi, vuosi jakojäännös 4
            int sata = vuosi % 400;
            
            if ( karkaus == 0 && vuosi % 100 != 0) { 
                Console.WriteLine("Vuosi on karkausvuosi.");
            }

            else if (karkaus == 0 && vuosi % 400 == 0)
            {
                Console.WriteLine("Vuosi on KAKKAUSvuosi.");
            }

            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi.");
            }




        }
    }
    }

