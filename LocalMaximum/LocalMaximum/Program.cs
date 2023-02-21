using System;

namespace LocalMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В ведите размер массива");

            int elements = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[elements];
            int minNumber = 0;
            int maxNumber = 100;

            Random random = new Random();

            for (int i = 0; i < elements; i++)
            {
                numbers[i] = random.Next(minNumber, maxNumber);
            }

            for (int i = 0; i < elements; i++)
            {
                Console.Write(numbers[i] + "\t");
            }

            Console.WriteLine();

            if (numbers[0] > numbers[1])
            {
                Console.WriteLine(numbers[0]);
            }

            if (numbers[elements - 1] > numbers[elements-2])
            {
                Console.WriteLine(numbers[elements-1]);
            }

            for (int j = 1; j < elements - 1; j++)
            {
                if (numbers[j] > numbers[j - 1] && numbers[j] > numbers[j + 1])
                {
                    Console.WriteLine($"{numbers[j-1]} {numbers[j]} {numbers[j+1]}");
                }
            }
        }
    }
}
