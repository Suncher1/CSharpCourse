using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1uppgift6
{
    class Uppgift6
    {
        static void Main(string[] args)
        {
            Console.Write("Första talet: ");
            string firstnumber = Console.ReadLine();
            Console.Write("Första talet: ");
            string secoundnumber = Console.ReadLine();

            int firstparse = int.Parse(firstnumber);
            int secoundparse = int.Parse(secoundnumber);

            int minsumma = Countsum(firstparse, secoundparse);
            Console.WriteLine($"Resultat: {minsumma}");
            Console.Read();
        }
        public static int Countsum(int first, int secound)
        {
            int summa = first + secound;
            return summa;
        }
    }
}
