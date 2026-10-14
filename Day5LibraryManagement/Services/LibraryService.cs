using System;
using System.Collections.Generic;
using System.Text;

namespace Day5LibraryManagement.Services
{

    using Day5LibraryManagement.Models;
    using global::Day5LibraryManagement.Models;

    public class LibraryService
    {
        private readonly List<Book> books = new();

        public bool AddBook(int id, string title, string author)
        {
            if (id <= 0 || string.IsNullOrWhiteSpace(title)
                || string.IsNullOrWhiteSpace(author))
            {
                return false;
            }

            bool duplicateId = books.Any(book => book.Id == id);

            if (duplicateId)
            {
                return false;
            }

            Book book = new Book(id, title.Trim(), author.Trim());

            books.Add(book);

            return true;
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public List<Book> SearchBooks(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return new List<Book>();
            }

            return books
                .Where(book =>
                    book.Title.Contains(
                        keyword, StringComparison.OrdinalIgnoreCase)
                    ||
                    book.Author.Contains(
                        keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public bool IssueBook(int id)
        {
            Book? book = books.FirstOrDefault(book => book.Id == id);

            if (book is null)
            {
                return false;
            }

            return book.Issue();
        }

        public bool ReturnBook(int id)
        {
            Book? book = books.FirstOrDefault(book => book.Id == id);

            if (book is null)
            {
                return false;
            }

            return book.ReturnBook();
        }
    }

}
