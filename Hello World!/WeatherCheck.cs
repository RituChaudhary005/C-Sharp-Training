/*Coding task: Write a program that stores a variable named temperature.
- If temperature is below 15, print "Cold".
- If temperature is from 15 to 29 inclusive, print "Moderate".
- If temperature is 30 or higher, print "Hot".
Use if, else if, and else. Test it with 10, 25, and 35.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_
{
    internal class WeatherCheck
    {
        public static void Run()
        {
            int temperature = 12;
            if (temperature < 15)
            {
                Console.WriteLine("It is Cold");
            }
            else if (temperature >= 15 && temperature <= 29)
            {
                Console.WriteLine("It is temperate");
            }
            else if(temperature >= 30)
            {
                Console.WriteLine("It is Hot");
            }
            else
            {
                Console.WriteLine("Invalid temperature"); 
            }
        }
    }
}
