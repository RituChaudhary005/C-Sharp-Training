using Day5LibraryManagement.Models;
using Day5LibraryManagement.Services;

namespace Day5LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            LibraryService library = new LibraryService();

            bool running = true;

            while (running)
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("   LIBRARY MANAGEMENT SYSTEM");
                Console.WriteLine("================================");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Search Books");
                Console.WriteLine("4. Issue Book");
                Console.WriteLine("5. Return Book");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string? input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;

                    case 2:
                        ViewBooks();
                        break;

                    case 3:
                        SearchBooks();
                        break;

                    case 4:
                        IssueBook();
                        break;

                    case 5:
                        ReturnBook();
                        break;

                    case 6:
                        running = false;
                        Console.WriteLine("Thank you for using the library system!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Select 1 to 6.");
                        break;
                }
            }

            void AddBook()
            {
                Console.Write("Enter book ID: ");

                if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
                {
                    Console.WriteLine("Book ID must be a positive number.");
                    return;
                }

                Console.Write("Enter book title: ");
                string? title = Console.ReadLine();

                Console.Write("Enter author name: ");
                string? author = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(title)
                    || string.IsNullOrWhiteSpace(author))
                {
                    Console.WriteLine("Title and author cannot be empty.");
                    return;
                }

                bool added = library.AddBook(id, title, author);

                if (added)
                {
                    Console.WriteLine("Book added successfully!");
                }
                else
                {
                    Console.WriteLine(
                        "Could not add book. The ID may already exist.");
                }
            }

            void ViewBooks()
            {
                List<Book> books = library.GetAllBooks();

                if (books.Count == 0)
                {
                    Console.WriteLine("No books found in the library.");
                    return;
                }

                Console.WriteLine("\n--- All Books ---");

                foreach (Book book in books)
                {
                    Console.WriteLine(book);
                }

                Console.WriteLine($"Total books: {books.Count}");
            }

            void SearchBooks()
            {
                Console.Write("Enter a title or author to search: ");
                string? keyword = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(keyword))
                {
                    Console.WriteLine("Search keyword cannot be empty.");
                    return;
                }

                List<Book> results = library.SearchBooks(keyword);

                if (results.Count == 0)
                {
                    Console.WriteLine("No matching books found.");
                    return;
                }

                Console.WriteLine("\n--- Search Results ---");

                foreach (Book book in results)
                {
                    Console.WriteLine(book);
                }
            }

            void IssueBook()
            {
                Console.Write("Enter the ID of the book to issue: ");

                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Please enter a valid book ID.");
                    return;
                }

                bool issued = library.IssueBook(id);

                Console.WriteLine(issued
                    ? "Book issued successfully!"
                    : "Book not found or already issued.");
            }

            void ReturnBook()
            {
                Console.Write("Enter the ID of the book to return: ");

                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Please enter a valid book ID.");
                    return;
                }

                bool returned = library.ReturnBook(id);

                Console.WriteLine(returned
                    ? "Book returned successfully!"
                    : "Book not found or it is already available.");
            }

        }
    }
}
