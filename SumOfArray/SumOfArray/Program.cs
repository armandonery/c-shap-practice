using System;

namespace SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of elements of an array!!");

            int[] numbers = { 1, 8, 5, 6, 7, 9 };
            int sum = 0;

            foreach (var num in numbers)
            {
                sum += num;
            }

            Console.WriteLine($"The sum of all elments in the array is: {sum}");

            Console.ReadLine();
        }
    }
}
