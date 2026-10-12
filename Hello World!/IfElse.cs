using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_
{
    internal class IfElse
    {
        public static void Run()
        {
            int age = 15;
            if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a teenager");
            }
            else
            {
                Console.WriteLine("You are not a teenager");
            }
        }
    }
}

