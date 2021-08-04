using System;

namespace ExchangeNumers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exchange numbers");

            Console.WriteLine("Before!!");
            Console.WriteLine("Number 1:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Number 2:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("After!!");
            Console.WriteLine($"Number 1: {n2}");
            Console.WriteLine($"Number 2: {n1}");
        }
    }
}
