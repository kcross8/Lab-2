using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string agree = "y";
            while (agree == "y")
            {
                Console.WriteLine("Welcome to the Grand Circus Room Detail Generator! ");
                Console.Write("Enter Length: ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());

                Console.Write("Enter height: ");
                double height = double.Parse(Console.ReadLine());

                double area = length * width;
                double perimeter = 2 * (length + width);
                double volume = length * width * height;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                Console.WriteLine("Continue? (y/n) ");
                agree = Console.ReadLine();
            }
        }
    }
}
