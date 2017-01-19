using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht06
{
    class Program
    {
        static void Main(string[] args)
        {
            int matka;
            double bensa = 1.595;
            double kulutus = 7.02/100;
            Console.Write("Kuinka pitkän matkan ajoit? ");   // Kysytään ikää
            string line = Console.ReadLine();
            matka = int.Parse(line);

            Console.WriteLine("Sinulta kului bensaa matkan aikana ");
            Console.WriteLine( matka * kulutus + " litraa.");
            Console.WriteLine("Ja se maksoi sinulle ");
            Console.WriteLine(kulutus * matka * bensa + " euroa.");

        }
    }
    }

