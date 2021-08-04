using System;

namespace CommonOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Common operations!!");

            Console.WriteLine("Number 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Number 2: ");
            double n2 = double.Parse(Console.ReadLine());

            //Operations
            double add = n1 + n2;
            double sub = n1 - n2;
            double mult = n1 * n2;
            double div = n1 / n2;

            Console.WriteLine($"Addition : {add}");
            Console.WriteLine($"Substraction : {sub}");
            Console.WriteLine($"Multiplication : {mult}");
            Console.WriteLine($"Division : {div}");

            Console.ReadLine();
        }
    }
}
