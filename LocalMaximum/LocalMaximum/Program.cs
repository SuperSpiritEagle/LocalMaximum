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
            int N;
            N = countElement;

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

            if (arrayNumbers[0] > arrayNumbers[1])
            {
                Console.WriteLine(arrayNumbers[0]);
            }

            if (arrayNumbers[N - 1] > arrayNumbers[N-2])
            {
                Console.WriteLine(arrayNumbers[N-1]);
            }

            for (int j = 1; j < countElement - 1; j++)
            {
                if (arrayNumbers[j] > arrayNumbers[j - 1] && arrayNumbers[j] > arrayNumbers[j + 1])
                {
                    Console.WriteLine($"{arrayNumbers[j-1]} {arrayNumbers[j]} {arrayNumbers[j+1]}");
                }
            }
        }
    }
}
