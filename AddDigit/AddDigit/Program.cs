using System;

namespace AddDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding the digits of a number!!");

            Console.WriteLine("Number: ");
            string number = Console.ReadLine();

            int total = 0;
            
            foreach(char number2 in number)
            {
                total += int.Parse(number2.ToString());
            }

            Console.WriteLine($"The sum of of the digits of {number} is: {total}");

            Console.ReadKey();
        }
    }
}
