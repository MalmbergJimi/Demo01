using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[9];

            luvut[0] = 1;       // Alustetaan taulukkoon valmiit arvot
            luvut[1] = 2;
            luvut[2] = 33;
            luvut[3] = 44;
            luvut[4] = 55;
            luvut[5] = 68;
            luvut[6] = 77;
            luvut[7] = 96;
            luvut[8] = 100;

            int i=0;
            for (i=0; i< luvut.Length; i++)     // For-silmukka
            {
                if (luvut[i] % 2 == 0) Console.WriteLine("Hep " + luvut[i]); // Kun jakojäännös kahdesta on nolla, tulostetaan hep.
            }

            }

        }
    }

