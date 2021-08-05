using System;

namespace ObtainCentury
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obtain century!");

            Console.WriteLine("Year: ");
            int year = int.Parse(Console.ReadLine());
            int century = (year - 1) / 100 + 1;

            Console.WriteLine((year<1)? "Ingrese a partir de 1 A.D" : $"Century {century}");

            Console.ReadLine();
        }
    }
}
