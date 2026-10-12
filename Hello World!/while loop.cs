using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_
{
    internal class While_loop
    {
        public static void Run()
        {
            int number = 1;
            int sum = 0;

            while (number <= 5)
            {
                sum += number;
                number++;
            }

            Console.WriteLine(number);
            Console.WriteLine(sum);
        }
    }
}
