using System;

namespace CSharp.net
{
    class InmatNummer
    {
        static void Main(string[] args)
        {
            Console.Write("Första talet: ");
            string firstnumber = Console.ReadLine();
            Console.Write("Första talet: ");
            string secoundnumber = Console.ReadLine();

            int firstconv = int.Parse(firstnumber);
            int secoundconv = int.Parse(secoundnumber);

            int minsumma = Countsum(firstconv, secoundconv);
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
