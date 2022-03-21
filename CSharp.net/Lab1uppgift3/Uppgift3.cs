using System;

namespace Lab1uppgift3
{
    class Uppgift3
    {
        static void Main(string[] args)
        {
            //Läs in ett tal som anger hur många värden man ska läsa in
            Console.Write("Hur många tal vill du läsa in?: ");
            string numberOfInputFromUser = Console.ReadLine();
            int numberOfInput = int.Parse(numberOfInputFromUser);

            int[] arrayOfNumberInputs = new int[numberOfInput];
            //var arrayOfNumberInputs = new int[numberOfInput];

            //Läser in numberOfInput tal
            for (int i = 0; i < numberOfInput; i++)
            {
                Console.Write($"Skriv in heltal {i + 1} av {numberOfInput}: ");
                string inputFromUser = Console.ReadLine();
                int inputValue = int.Parse(inputFromUser);
                arrayOfNumberInputs[i] = inputValue;
            }

            for (int i = 0; i < numberOfInput; i++)
            {
                Console.Write($"{arrayOfNumberInputs[i]} ");
            }

            //Skriv ut det minsta och största värdet
            Array.Sort(arrayOfNumberInputs);

            Console.WriteLine("\nSorted array:" );
            //int counter = 1;
            foreach (var item in arrayOfNumberInputs)
            {
                //counter++;
                Console.Write($"{item} ");
            }

            var minimumNumber = arrayOfNumberInputs[0];
            var maximumNumber = arrayOfNumberInputs[arrayOfNumberInputs.Length - 1];

            Console.Write($"\nMinsta tal är {minimumNumber} och största tal är {maximumNumber}");

            Console.Read();
        }
    }
}
