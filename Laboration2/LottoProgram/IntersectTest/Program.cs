using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myLottoRow = { 44, 26, 92, 30, 71, 38 };            
            int rightAnswersFive = 0;
            int rightAnswersSix = 0;
            int rightAnswersSeven = 0;



            // loop 1010 ggr (input)
            // start
            int[] randomLottoRow = { 39, 59, 83, 47, 26, 4, 30 };
            IEnumerable<int> commonNumbers = myLottoRow.Intersect(randomLottoRow);
            int rightAnswers = commonNumbers.Count();
            
            if(rightAnswers == 7)
            {
                rightAnswersSeven++;
            }

            // slut loop

            // uppdatera 3 text boxar med värdet i variablerna 5,6 och 7


            Console.WriteLine($"Antal element {commonNumbers.Count()}");
            Console.Read();
        }
    }
}
