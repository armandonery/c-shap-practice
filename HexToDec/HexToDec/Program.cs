using System;

namespace HexToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert hexadecimal number to decimal!!");

            Console.WriteLine("Enter hex number: ");
            string hex = Console.ReadLine();

            int dec = Convert.ToInt32(hex, 16);

            Console.WriteLine($"Decimal number: {dec}");

            Console.ReadLine();
        }
    }
}
