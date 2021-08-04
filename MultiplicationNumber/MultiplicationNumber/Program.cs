using System;

namespace MultiplicationNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication number!!");

            Console.WriteLine("Number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <=10; i++)
            {
                int res = number * i;
                Console.WriteLine($"{number} x {i} = {res}");
            }

            Console.ReadLine();
        }
    }
}
