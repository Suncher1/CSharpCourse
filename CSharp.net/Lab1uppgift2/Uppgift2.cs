using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1uppgift2
{
    class Uppgift2
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in ett heltal: ");
            string number = Console.ReadLine();

            int numberparse = int.Parse(number);

            if (numberparse == 0)
            {
                Console.WriteLine($"The number is {numberparse} and is u guessed it zero!");
            }
            if (numberparse < 0)
            {
                Console.WriteLine($"The number is {numberparse} and its negative!");
            }
            if (numberparse > 0)
            {
                Console.WriteLine($"The number is {numberparse} and its positive!");
            }
            Console.Read();
        }
    }
}
