using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int result = Search(new[] { 4, 7, 11, 14, 18, 24, 28, 31, 36, 39, 43, 56, 59, 63, 67, 70, 72, 79 }, 28);
            Console.WriteLine($"The index of 28 is {result}");
        }

        static int Search(int[] numbers, int target)
        {
            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;

            while (leftIndex < rightIndex)
            {
                int middleIndex = (leftIndex + rightIndex) / 2;
                if (target < numbers[middleIndex]) // too high
                {
                    rightIndex = middleIndex - 1;
                }
                else if (target > numbers[middleIndex]) // too low
                {
                    leftIndex = middleIndex + 1;
                } 
                else
                {
                    return middleIndex;
                }
            }
            return -1;
        }
    }
}
