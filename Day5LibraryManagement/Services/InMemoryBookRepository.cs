using System.Collections.Generic;
using System.Linq;
using Day5LibraryManagement.Models;

namespace Day5LibraryManagement.Services
{
    public class InMemoryBookRepository : IBookRepository
    {
        private readonly List<Book> _books = new();

        public bool Add(Book book)
        {
            if (Exists(book.Id)) return false;
            _books.Add(book);
            return true;
        }

        public List<Book> GetAll() => _books.ToList();

        public List<Book> Search(string keyword)
        {
            keyword = (keyword ?? string.Empty).ToLower();
            return _books.Where(b =>
                b.Title.ToLower().Contains(keyword) ||
                b.Author.ToLower().Contains(keyword)).ToList();
        }

        public bool Issue(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book == null) return false;
            _books.Remove(book); // simple issued-state model
            return true;
        }

        public bool Return(int id)
        {
            if (Exists(id)) return false;
            _books.Add(new Book(id, "Unknown Title", "Unknown Author"));
            return true;
        }

        public bool Exists(int id) => _books.Any(b => b.Id == id);
    }
}