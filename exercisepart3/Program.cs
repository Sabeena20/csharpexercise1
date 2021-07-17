using System;

namespace exercisepart3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles you have driven?");
            string input = Console.ReadLine();
            int miles = int.Parse(input);

            Console.WriteLine("How many gallons of gas you used?");
            string input1 = Console.ReadLine();
            int gallons = int.Parse(input1);

            int milesPerGallons = miles / gallons;
            Console.WriteLine("The MPG is " + milesPerGallons);

        }
    }
}
