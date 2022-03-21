using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1uppgift7
{
    class Uppgift7
    {
        static void Main(string[] args)
        {
            Console.Write("Input a character: ");
            char character = Console.ReadKey().KeyChar;

            IsAlpha(character);
            Console.Read();
        }
        static void IsAlpha(char ch)
        {
            if (Char.IsLetter(ch))
            {
                Console.WriteLine("\nThe character is part of an alpahbet");
            }
            else
            {
                Console.WriteLine("\nThe character is not part of an alpahbet");
            }
        }
    }
}
