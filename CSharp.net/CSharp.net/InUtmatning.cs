using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.net
{
    class InUtmatning
    {
        static void Main(string[] args)
        {
            string firstname;
            string lastname;

            Console.WriteLine("Skriv in ditt namn: ");
            firstname = Console.ReadLine();
            Console.Write("Skriv in ditt efternamn: ");
            lastname = Console.ReadLine();


            Console.WriteLine($"Hej {firstname } {lastname}!");
            Console.Read();
        }
    }
}