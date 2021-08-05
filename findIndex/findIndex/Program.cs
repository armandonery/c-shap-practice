using System;

namespace findIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find number in array!");

            int[] numbers = { 1, 3 , 6, 5, 6, 8 };

            Console.WriteLine("Number: ");
            int number = int.Parse(Console.ReadLine());

            int count = 0;

            foreach (var num in numbers)
            {
                if (num == number)
                {
                    count++;
                }
            }

            Console.WriteLine($"The number {number} was found on index {count}");

            Console.ReadLine();
        }
    }
}
