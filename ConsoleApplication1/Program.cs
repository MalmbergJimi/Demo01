﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] luvut = new int[5];

            Console.WriteLine("Haluan viisi kokonaislukua. Anna luku 1: ");  // KYSYTÄÄN 5 LUKUA KÄYTTÄJÄLTÄ
            string line = Console.ReadLine();
            luvut[0] = int.Parse(line);                                     // Sijoitetaan luvut taulukkoon

            Console.WriteLine("Anna luku 2: ");
            string line1 = Console.ReadLine();
            luvut[1] = int.Parse(line1);

            Console.WriteLine("Anna luku 3: ");
            string line2 = Console.ReadLine();
            luvut[2] = int.Parse(line2);

            Console.WriteLine("Anna luku 4: ");
            string line3 = Console.ReadLine();
            luvut[3] = int.Parse(line3);

            Console.WriteLine("Anna luku 5: ");
            string line4 = Console.ReadLine();
            luvut[4] = int.Parse(line4);
            
            Console.Write("Kiitos! Antamasi luvut ovat: ");

            int i;
            for (i = 4; i >= 0; i--)     // For-silmukka joka tulostaa annetut luvut käännetyssä järjestyksessä
            {
                Console.Write(luvut[i] + ",");
            }

            Console.WriteLine();
        }
    }
    }

