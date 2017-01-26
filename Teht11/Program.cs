using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht11
{
    class Program
    {
        static void Main(string[] args)
        {
            int rivit, i, h;
            string tahti = "*";

            Console.WriteLine("Montako tähtiriviä haluat? ");
            string line = Console.ReadLine();
            rivit = int.Parse(line);

            

            for (i=0; i < rivit; i++)
            {
                
                for (h=0; h<i; h++)
                {
                 Console.Write(tahti);
                }

                Console.WriteLine(tahti);
            }


        }



    }
}
