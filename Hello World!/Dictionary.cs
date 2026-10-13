using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World_
{
    internal class Dictionary
    {
    
        public static void Run()
        {
            Dictionary<string, int> studentMarks = new Dictionary<string, int>
            {
                { "Alice", 85 },
                { "Bob", 92 },
                { "Charlie", 78 },
                { "David", 90 }
            };
            Console.WriteLine("Student Marks:");
            foreach (var student in studentMarks)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
            // Accessing a specific student's marks
            string studentName = "Bob";
            if (studentMarks.TryGetValue(studentName, out int marks))
            {
                Console.WriteLine($"\n{studentName}'s marks: {marks}");
            }
            else
            {
                Console.WriteLine($"\n{studentName} not found in the dictionary.");
            }
        }
    }
}
