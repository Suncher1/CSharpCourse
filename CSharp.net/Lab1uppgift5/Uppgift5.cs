using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1uppgift5
{
    class Uppgift5
    {
        static void Main(string[] args)
        {
            const int LengthOfArray = 4;
            double[] arrayOfNumberInputs = new double[LengthOfArray];
            //var arrayOfNumberInputs = new int[numberOfInput];

            //Läser in numberOfInput tal
            for (int i = 0; i < LengthOfArray; i++)
            {
                Console.Write($"Skriv in heltal {i + 1} av {LengthOfArray}: ");
                string inputFromUser = Console.ReadLine();
                double inputValue = double.Parse(inputFromUser);
                arrayOfNumberInputs[i] = inputValue;
            }

            for (int i = 0; i < LengthOfArray; i++)
            {
                Console.Write($"{arrayOfNumberInputs[i]} ");
            }

            //Skriv ut det minsta och största värdet
            Array.Sort(arrayOfNumberInputs);

            Console.WriteLine("\nSorted array:");
            //int counter = 1;
            foreach (var item in arrayOfNumberInputs)
            {
                //counter++;
                Console.Write($"{item} ");
            }
            var averageValue = arrayOfNumberInputs.Sum() / arrayOfNumberInputs.Length;

            var numberOfElementsInArray = arrayOfNumberInputs.Length;
            double medianValue; 
            
            if(numberOfElementsInArray % 2 == 0)
            {
                var middleElement1 = arrayOfNumberInputs[(numberOfElementsInArray / 2) - 1];
                var middleElement2 = arrayOfNumberInputs[numberOfElementsInArray / 2];
                medianValue = (middleElement1 + middleElement2) / 2;
            }
            else
            {
                medianValue = arrayOfNumberInputs[numberOfElementsInArray / 2];
            }


            Console.Write($"\nMedelvärdet är {averageValue:0.##} och medianvärdet är {medianValue} ");

            Console.Read();
        }
    }
}
