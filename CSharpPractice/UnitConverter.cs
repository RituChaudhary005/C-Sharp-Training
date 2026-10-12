
using System;

namespace Hello_World_
{
    internal class UnitConverter
    {
        public static void Run()
        {
            Console.WriteLine("===== UNIT CONVERTER =====");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Kilometers to Miles");
            Console.WriteLine("3. Kilograms to Pounds");

            Console.Write("Choose conversion (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter value: ");
            double value = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            string unit = "";

            switch (choice)
            {
                case 1:
                    result = (value * 9 / 5) + 32;
                    unit = "Fahrenheit";
                    break;

                case 2:
                    result = value * 0.621371;
                    unit = "Miles";
                    break;

                case 3:
                    result = value * 2.20462;
                    unit = "Pounds";
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    return;
            }

            Console.WriteLine($"Converted value: {result:F2} {unit}");
        }
    }
}