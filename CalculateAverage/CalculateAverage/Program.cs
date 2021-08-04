using System;

namespace CalculateAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //globla
            int total = 4;

            Console.WriteLine($"Calculate average of {total} numbers!");

            Console.WriteLine("Number 1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Number 2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Number 3: ");
            double n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Number 4: ");
            double n4 = double.Parse(Console.ReadLine());

            double average = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine($"Average: {average}");

            Console.ReadLine();
        }
    }
}
