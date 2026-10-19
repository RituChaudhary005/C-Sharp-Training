using System.Collections.Generic;
using Day5LibraryManagement.Models;

namespace Day5LibraryManagement.Services
{
    public interface IBookRepository
    {
        bool Add(Book book);
        List<Book> GetAll();
        List<Book> Search(string keyword);
        bool Issue(int id);
        bool Return(int id);
        bool Exists(int id);
    }
}