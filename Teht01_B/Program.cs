using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01_B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään numero
            int number;
            Console.Write("Annappa luku: ");
            string line = Console.ReadLine();   // "1"
            bool result = int.TryParse(line,out number);           // "1" -> 1
            if (result == true)
            { 
                        

            // Switch case -rakenne
            switch (number)
            {
                case 1: Console.WriteLine("Yksi"); break;
                case 2: Console.WriteLine("Kaksi"); break;
                case 3: Console.WriteLine("Kolme"); break;
                default: Console.WriteLine("Joku muu luku"); break;
            }
            }
            else
            {
                Console.WriteLine("Ei kelpaa!");
            }
            // Odota Enteriä
            Console.ReadLine();
        }
    }
}
