using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_
{
    internal class ElseIf
    {
        public static void Run()
        {
            int marks = 85;
            if (marks >= 90)
            {
                Console.WriteLine("Grade A+");
            }
            else if(marks>=80)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
