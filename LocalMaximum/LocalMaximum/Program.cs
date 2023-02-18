using System;

namespace LocalMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В ведите размер массива");

            int countElement = Convert.ToInt32(Console.ReadLine());
            int[] arrayNumbers = new int[countElement];
            int minNumber = 0;
            int maxNumber = 100;
            int localMaximum;
            int minLocal;
            int maxLocal;
            int looksFor = 1;

            Random random = new Random();

            for (int i = 0; i < countElement; i++)
            {
                arrayNumbers[i] = random.Next(minNumber, maxNumber);
            }

            for (int i = 0; i < countElement; i++)
            {
                Console.Write(arrayNumbers[i] + "\t");
            }

            Console.WriteLine();

            for (int i = 0; i <looksFor; i++)
            {
                for (int j = 1; j < countElement-1; j++)
                {
                    if (arrayNumbers[j] > arrayNumbers[j - 1] && arrayNumbers[j]>arrayNumbers[j+1])
                    {
                        localMaximum = arrayNumbers[j];
                        minLocal = arrayNumbers[j - 1];
                        maxLocal = arrayNumbers[j + 1];
                        Console.WriteLine($"{minLocal} {localMaximum} {maxLocal}");
                    }  
                }  
            }  
        }
    }
}
