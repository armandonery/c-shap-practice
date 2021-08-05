using System;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest word in string!");

            Console.WriteLine("Word: ");
            String word = Console.ReadLine();

            string[] words = word.Split();

            string Longest = "";

            //Foerach all word
            foreach (string res in words)
            {
                if (res.Length > Longest.Length)
                {
                    Longest = res;
                }
            }

            Console.WriteLine($"The longest word in the sentences is: {Longest}");

            Console.ReadLine();
        }
    }
}
