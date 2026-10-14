using System;
using System.Collections.Generic;
using System.Text;

namespace Day5LibraryManagement.Models
{
  

    public class Book
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool IsAvailable { get; private set; }

        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
            IsAvailable = true;
        }

        public bool Issue()
        {
            if (!IsAvailable)
                return false;

            IsAvailable = false;
            return true;
        }

        public bool ReturnBook()
        {
            if (IsAvailable)
                return false;

            IsAvailable = true;
            return true;
        }

        public override string ToString()
        {
            string status = IsAvailable ? "Available" : "Issued";
            return $"ID: {Id} | Title: {Title} | Author: {Author} | Status: {status}";
        }
    }
}

