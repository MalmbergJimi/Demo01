using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään numero
            int pistem;
            Console.Write("Kuinka paljon sait pisteitä kokeesta? ");
            string line = Console.ReadLine();   
            pistem = int.Parse(line);          
            // Mikä numero...

            // Switch case -rakenne
            switch (pistem)
            {
                case 0:
                case 1: Console.WriteLine("Numerosi on nolla, 0!"); break;

                case 2:
                case 3: Console.WriteLine("Numerosi on yksi, 1!"); break;

                case 4:
                case 5: Console.WriteLine("Numerosi on kaksi, 2!"); break;

                case 6:
                case 7: Console.WriteLine("Numerosi on kolme, 3!"); break;

                case 8:
                case 9: Console.WriteLine("Numerosi on neljä, 4!"); break;

                case 10:
                case 11:
                case 12: Console.WriteLine("Numerosi on viisi, 5!"); break;

                default: Console.WriteLine("Ei voi olla, huijjaat."); break;
            }
            // Odota Enteriä
            Console.ReadLine();


        }
    }
}
