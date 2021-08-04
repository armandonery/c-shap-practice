using System;

namespace AddTwoNumbersx3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add two numbers!");

            Console.WriteLine("Number 1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Number 2: ");
            int n2 = int.Parse(Console.ReadLine());

            //if condition ? do this : else do this
            int res = (n1 == n2) ? (n1 + n2) * 3 : n1 + n2;

            Console.WriteLine($"Result: {res}");

            Console.ReadLine();
        }
    }
}
