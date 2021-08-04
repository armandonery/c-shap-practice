using System;

namespace MultiplyThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Global
            int quantity = 3;

            Console.WriteLine($"Multiply {quantity} numbers!");

            Console.WriteLine("Number 1:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Number 2:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Number 3:");
            double n3 = double.Parse(Console.ReadLine());

            double res = n1 * n2 * n3;

            Console.WriteLine($"Result of multiplication is: {res}");

            Console.ReadLine();
        }
    }
}
