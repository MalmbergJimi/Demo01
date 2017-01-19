using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3, apu;

            Console.WriteLine(" Anna kolme kokonaislukua, niin tulostan niistä suurimman. Anna ensimmäinen luku: ");
            string line1 = Console.ReadLine();
            luku1 = int.Parse(line1);

            Console.WriteLine(" Anna toinen luku: ");
            string line2 = Console.ReadLine();
            luku2 = int.Parse(line2);

            Console.WriteLine(" Anna kolmas luku: ");
            string line3 = Console.ReadLine();
            luku3 = int.Parse(line3);


            if (luku1 > luku2)
            {
                apu = luku1;
                luku1 = luku2;
                luku2 = apu;
            }
            if (luku2 > luku3)
            {
                apu = luku2;
                luku2 = luku3;
                luku3 = apu;
            }
            if (luku1 > luku2)
            {
                apu = luku1;
                luku1 = luku2;
                luku2 = apu;
            }

            Console.WriteLine("Suurin luku on luku " + luku3);
        }
    }
}
