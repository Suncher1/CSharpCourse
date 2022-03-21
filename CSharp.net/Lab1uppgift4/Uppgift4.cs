using System;
using System.Text.RegularExpressions;

namespace Lab1uppgift4
{
    class Uppgift4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din email: ");
            string check = Console.ReadLine();
            string inputText = check;
            string pattern = @"[\w-\.]+@([\w-]+\.)+[\w-]{2,4}";
            var result = Regex.Matches(inputText, pattern);

            Console.Write($"{result.Count}");
            Console.Read();
        }
    }
}
