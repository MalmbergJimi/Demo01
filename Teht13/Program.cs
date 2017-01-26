using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3, luku4, luku5;
            int apu;

            Console.WriteLine("Mitä mieltä olitte hypystä? Tuomari 1: ");  //Kysytään Tuomareilta tulokset
            string line = Console.ReadLine();
            luku1 = int.Parse(line);

            Console.WriteLine("Tuomari 2: ");
            string line1 = Console.ReadLine();
            luku2 = int.Parse(line1);

            Console.WriteLine("Tuomari 3: ");
            string line2 = Console.ReadLine();
            luku3 = int.Parse(line2);

            Console.WriteLine("Tuomari 4: ");
            string line3 = Console.ReadLine();
            luku4 = int.Parse(line3);

            Console.WriteLine("Tuomari 5: ");
            string line4 = Console.ReadLine();
            luku5 = int.Parse(line4);


            if (luku1 > luku2)   // ETSITÄÄN SUURIN LUKU LUVUN5 PAIKALLE
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

            if (luku3 > luku4)
            {
                apu = luku3;
                luku3 = luku4;
                luku4 = apu;
            }

            if (luku4 > luku5)
            {
                apu = luku4;
                luku4 = luku5;
                luku5 = apu;
            }

            if (luku1 > luku2)
            {
                apu = luku1;
                luku1 = luku2;
                luku2 = apu;
            }
            // TÄSSÄ VAIHEESSA SUURIN LUKU ON LUKU5

            if (luku4 < luku3)  // ETSITÄÄN PIENEN LUKU LUVUN1 PAIKALLE
            {
                apu = luku4;
                luku4 = luku3;
                luku3 = apu;
            }
            if (luku3 < luku2)
            {
                apu = luku3;
                luku3 = luku2;
                luku2 = apu;
            }

            if (luku2 > luku1)
            {
                apu = luku2;
                luku2 = luku1;
                luku1 = apu;
            }

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

            if (luku3 > luku4)
            {
                apu = luku3;
                luku3 = luku4;
                luku4 = apu;
            }

            if (luku4 > luku5)
            {
                apu = luku4;
                luku4 = luku5;
                luku5 = apu;
            }

            if (luku1 > luku2)
            {
                apu = luku1;
                luku1 = luku2;
                luku2 = apu;
            }
            // TÄSSÄ VAIHEESSA PIENIN LUKU ON LUKU1

            // Console.Write(luku1 + "," + luku2 + "," + luku3 + "," + luku4 + "," + luku5); varmistetaan että syntaxi toimii
            Console.WriteLine(luku2 + luku3 + luku4); // Lasketaan kolme keskimmäistä lukua yhteen
        }
    }
}
