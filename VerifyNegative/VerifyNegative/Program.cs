using System;

namespace VerifyNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verify if one number is negative!");

            Console.WriteLine("Number 1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Number 2: ");
            int n2 = int.Parse(Console.ReadLine());

            bool res = (n2 < 0  && n1 >= 0) || (n1 < 0 && n2 >= 0);

            Console.WriteLine($"Result: {res}");

            Console.ReadLine();
        }
    }
}
