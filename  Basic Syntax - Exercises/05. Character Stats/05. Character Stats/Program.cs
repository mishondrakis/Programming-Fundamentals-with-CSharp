using System;

namespace _05._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 4, 22, 1 };

            var biggestNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > biggestNumber) 
                {
                    biggestNumber = numbers[i];
                }
            }
            Console.WriteLine(biggestNumber);

        }
    }
}
