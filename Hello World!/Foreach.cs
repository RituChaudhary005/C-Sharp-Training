using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_
{
    internal class Foreach
    {
        public static void Run() { 
        



            string[] students = { "Ritu", "Aman", "Priya", "Rahul" };

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }
    }

}

