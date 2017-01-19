using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään numero
            int number1, number2, number3;

           
            Console.Write("I want three numbers, give me first number: "); // pyydetään kolme numeroa, eka numero
            string line1 = Console.ReadLine();   
            number1 = int.Parse(line1);

            Console.Write("Give me second number: ");   // pyydetään toinen numero
            string line2 = Console.ReadLine();
            number2 = int.Parse(line2);

            Console.Write("Give me third number: ");    // pyydetään kolmas numero
            string line3 = Console.ReadLine();
            number3 = int.Parse(line3);

            int sum = number1 + number2 + number3; // lasketaan summa
            int ave = sum / 3; // lasketaan keskiarvo
         
            Console.WriteLine("The sum is:" + sum);     
            Console.WriteLine("and the average is:" + ave);
            

            // Odota Enteriä
            Console.ReadLine();


        }
    }
}
