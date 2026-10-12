using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_
{
    public class Calculator
    {
        public static void Run()
        {
            Console.WriteLine("---Simple Calculator---");
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;
            double quotient = num1 / num2;
            double remainder = num1 % num2;
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Difference is {difference}");
            Console.WriteLine($"Product is {product}");
            Console.WriteLine($"Quotient is {quotient}");
            Console.WriteLine($"remainder is {remainder}");

        }
    }
}
