using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_
{
    internal class For_loop
    {
        public static void Run()
        {
            int number = 7;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
