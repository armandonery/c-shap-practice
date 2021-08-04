using System;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding two numbers");

            int a = 6;
            int b = 6;

            int res = a + b;

            Console.WriteLine($"Number 1: {a}");
            Console.WriteLine($"Number 2: {b}");
            Console.WriteLine($"Result of {a} + {b} = {res}");

        }
    }
}
