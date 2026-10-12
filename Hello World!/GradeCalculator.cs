
using System;

public class GradeCalculator
{
    public static void Run()
    {
        Console.Write("Enter your marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        string grade = CalculateGrade(marks);

        Console.WriteLine("Grade: " + grade);
    }

    static string CalculateGrade(int marks)
    {
        if (marks < 0 || marks > 100)
        {
            return "Invalid marks";
        }
        else if (marks >= 90)
        {
            return "A+";
        }
        else if (marks >= 80)
        {
            return "A";
        }
        else if (marks >= 70)
        {
            return "B";
        }
        else if (marks >= 60)
        {
            return "C";
        }
        else if (marks >= 40)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}
