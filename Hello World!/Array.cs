using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_
{
    

    public class ArrayPractice
    {
        public static void Run()
        {
            int[] marks = { 80, 65, 95, 75, 85 };

            System.Array.Sort(marks);

            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }
        }
    }
}
    

