using System;

namespace Lab1uppgift1
{
    class Uppgift1
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.Read();
        }
    }
}
