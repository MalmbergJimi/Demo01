using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika;
            Console.Write("Kuinka vanha olet? ");   // Kysytään ikää
            string line = Console.ReadLine();
            ika = int.Parse(line);

            //else-if rakenne
            if (ika<18)                             
            {
                Console.WriteLine("Hahaa, olet alaikäinen!");
            }
            else if (ika<65 || ika>18)
            {
                Console.WriteLine("Olet näköjään täysi-ikäinen.");
            }
            else
            {
                Console.WriteLine("Olet seniori iässä.");
            }
            
            }

        


        }
    }

