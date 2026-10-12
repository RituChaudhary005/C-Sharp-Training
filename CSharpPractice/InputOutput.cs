using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_
{
    internal class InputOutput
    {
        public static void Run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is: " + name);
        }
    }
}
