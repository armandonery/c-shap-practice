using System;

namespace reverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse a sentence!");

            Console.WriteLine("Sentence: ");
            string word = Console.ReadLine();

            Console.WriteLine($"Reversed word is: {reverseString(word)}");

            //Method
            static string reverseString(string word)
            {
                string[] words = word.Split(' ');
                Array.Reverse(words);

                return string.Join(' ', words);
            }

            Console.ReadLine();

        }
    }
}
