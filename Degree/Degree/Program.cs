using System;

namespace Degree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Degree operations!!");

            Console.WriteLine("Add Celcius degree:");
            double celcius = double.Parse(Console.ReadLine());
            
            double kelvin = celcius + 273.15;
            double fahrenheit = (celcius * 9 + (32 * 5) / 5);

            //res
            Console.WriteLine($"{celcius}°C equals to {kelvin}°K");
            Console.WriteLine($"{celcius}°C equals to {fahrenheit}°F");

            Console.ReadLine();
        }
    }
}
