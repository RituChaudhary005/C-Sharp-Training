using System.Collections.Generic;
using Day5LibraryManagement.Models;

namespace Day5LibraryManagement.Services
{
    public class LibraryService
    {
        private readonly IBookRepository _repository;

        public LibraryService(IBookRepository repository)
        {
            _repository = repository;
        }

        public bool AddBook(int id, string title, string author)
        {
            var book = new Book(id, title, author);
            return _repository.Add(book);
        }

        public List<Book> GetAllBooks() => _repository.GetAll();

        public List<Book> SearchBooks(string keyword) => _repository.Search(keyword);

        public bool IssueBook(int id) => _repository.Issue(id);

        public bool ReturnBook(int id) => _repository.Return(id);
    }
}