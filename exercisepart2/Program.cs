using System;

namespace exercisepart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length:");
            string length = Console.ReadLine();
            int rectLength = int.Parse(length);
            Console.WriteLine("The length is " + rectLength);

            Console.WriteLine("PLease enter the width:");
            string width = Console.ReadLine();
            int rectWidth = int.Parse(width);
            Console.WriteLine("The width is " + rectWidth);

            int area = rectLength * rectWidth;
            Console.WriteLine("The area is " + area);
        }
    }
}
