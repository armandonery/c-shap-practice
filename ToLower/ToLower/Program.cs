using System;

namespace ToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert string to lowercase!");

            Console.WriteLine("String: ");
            string word = Console.ReadLine();

            Console.WriteLine("Lowercased word: " + word.ToLower());

            Console.ReadLine();
        }
    }
}
