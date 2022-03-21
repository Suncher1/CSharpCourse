using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.net
{
    class GissaTal
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int answer = rand.Next(0, 1000);
            int guess = -1;

            while(guess != answer)
            {
                guess = int.Parse(Console.ReadLine());
                if(guess > answer)
                {
                    Console.WriteLine("Your guess is to large! ");
                }else if(guess < answer)
                {
                    Console.WriteLine("Your guess is to small! ");
                }
            }

            Console.WriteLine($"You guessed correct, the number was {answer}! ");
            Console.Read();
        }
    }
}
