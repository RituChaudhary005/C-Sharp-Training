
using Hello_World_;
using System;
using System.Collections.Generic;

namespace CSharpPractice;

public class StudentMarksManager
{
    private readonly Dictionary<int, Student> students = new();

    public void Run()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Student Marks Manager ---");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. View all students");
            Console.WriteLine("3. Search by ID");
            Console.WriteLine("4. Show class average");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;

                case "2":
                    ViewStudents();
                    break;

                case "3":
                    SearchStudent();
                    break;

                case "4":
                    ShowAverage();
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    private void AddStudent()
    {
        Console.Write("Enter student ID: ");

        if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
        {
            Console.WriteLine("Enter a valid positive ID.");
            return;
        }

        if (students.ContainsKey(id))
        {
            Console.WriteLine("This student ID already exists.");
            return;
        }

        Console.Write("Enter student name: ");
        string? name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be empty.");
            return;
        }

        Console.Write("Enter marks (0-100): ");

        if (!double.TryParse(Console.ReadLine(), out double marks)
            || marks < 0 || marks > 100)
        {
            Console.WriteLine("Marks must be between 0 and 100.");
            return;
        }

        students.Add(id, new Student
        {
            Id = id,
            Name = name.Trim(),
            Marks = marks
        });

        Console.WriteLine("Student added successfully.");
    }

    private void ViewStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        foreach (Student student in students.Values)
        {
            Console.WriteLine(
                $"ID: {student.Id}, Name: {student.Name}, " +
                $"Marks: {student.Marks}, Result: {student.GetResult()}");
        }
    }

    private void SearchStudent()
    {
        Console.Write("Enter student ID: ");

        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        if (students.TryGetValue(id, out Student? student))
        {
            Console.WriteLine(
                $"{student.Name}: {student.Marks} marks - " +
                student.GetResult());
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    private void ShowAverage()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No marks available.");
            return;
        }

        double total = 0;

        foreach (Student student in students.Values)
        {
            total += student.Marks;
        }

        double average = total / students.Count;

        Console.WriteLine($"Class average: {average:F2}");
    }
}


