using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_
{
    internal class NestedIf
    {
        public static void Run()
        {
           bool isLoggedIn = true;
           bool isAdmin = false;
            if (isLoggedIn)
            {
                if (isAdmin)
                {
                    Console.WriteLine("Welcome, Admin!");

                }
                else
                {
                    Console.WriteLine("Welcome, User!");
                }
                
            }
        }
    }
}