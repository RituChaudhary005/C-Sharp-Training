Day5LibraryManagement

A beginner-friendly C# console Library Management project.

Requirements
- .NET 10 SDK (or change TargetFramework in the .csproj to an installed SDK target)
- 
Run
Open a terminal in the folder containing Day5LibraryManagement.csproj and run:
dotnet build
dotnet run

Features
- Add books
- View all books
- Search by ID
- Issue a book
- Return a book
- Validate input and prevent duplicate IDs

Structure
- Program.cs — menu and user input
- Models/Book.cs — book data and availability rules
- Services/LibraryService.cs — book collection and library operations
Books are stored in memory, so data resets when the application exits.