using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_
{
   public class List
    {
        public static void Run()
        {
            List<int> marks = new List<int>
{
    80, 35, 90, 65, 40
};

            int total = 0;
            int passCount = 0;

            foreach (int mark in marks)
            {
                total += mark;

                if (mark >= 40)
                {
                    passCount++;
                }
            }

            double average = (double)total / marks.Count;

            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Passed: {passCount}");
            Console.WriteLine($"Failed: {marks.Count - passCount}");
        }
    }
}
