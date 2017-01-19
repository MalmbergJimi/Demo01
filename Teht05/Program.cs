using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekuntia;
            Console.WriteLine("Anna sekuntimäärä niin muunnan sen tunneiksi, minuuteiksi ja sekunneiksi: ");
            string line = Console.ReadLine();
            sekuntia = int.Parse(line);

            if (sekuntia >= 3600)
            {
                Console.WriteLine(sekuntia / 3600);
            }

            else
            {
                Console.WriteLine("No ei ihan");
            }

        }
    }
}
