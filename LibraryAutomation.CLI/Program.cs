using LibraryAutomation.Base.Entities.Concrete;
using LibraryAutomation.Base.Entities.Abstract;
using System;
using LibraryAutomation.Base.Utilities;

// Display the welcome banner
ConsoleColor originalColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("██╗     ██╗██████╗ ██████╗  █████╗ ██████╗ ██╗   ██╗    ███████╗██╗   ██╗███████╗████████╗███████╗███╗   ███╗");
Console.WriteLine("██║     ██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗ ██╔╝    ██╔════╝╚██╗ ██╔╝██╔════╝╚══██╔══╝██╔════╝████╗ ████║");
Console.WriteLine("██║     ██║██████╔╝██████╔╝███████║██████╔╝ ╚████╔╝     ███████╗ ╚████╔╝ ███████╗   ██║   █████╗  ██╔████╔██║");
Console.WriteLine("██║     ██║██╔══██╗██╔══██╗██╔══██║██╔══██╗  ╚██╔╝      ╚════██║  ╚██╔╝  ╚════██║   ██║   ██╔══╝  ██║╚██╔╝██║");
Console.WriteLine("███████╗██║██████╔╝██║  ██║██║  ██║██║  ██║   ██║       ███████║   ██║   ███████║   ██║   ███████╗██║ ╚═╝ ██║");
Console.WriteLine("╚══════╝╚═╝╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝       ╚══════╝   ╚═╝   ╚══════╝   ╚═╝   ╚══════╝╚═╝     ╚═╝");
Console.WriteLine("                                                                                                              ");
Console.WriteLine("          ▄▄▄       █    ██ ▄▄▄█████▓ ▒█████   ███▄ ▄███▓ ▄▄▄     ▄▄▄█████▓ ██▓ ▒█████   ███▄    █ ");
Console.WriteLine("         ▒████▄     ██  ▓██▒▓  ██▒ ▓▒▒██▒  ██▒▓██▒▀█▀ ██▒▒████▄   ▓  ██▒ ▓▒▓██▒▒██▒  ██▒ ██ ▀█   █ ");
Console.WriteLine("         ▒██  ▀█▄  ▓██  ▒██░▒ ▓██░ ▒░▒██░  ██▒▓██    ▓██░▒██  ▀█▄ ▒ ▓██░ ▒░▒██▒▒██░  ██▒▓██  ▀█ ██▒");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("         ░██▄▄▄▄██ ▓▓█  ░██░░ ▓██▓ ░ ▒██   ██░▒██    ▒██ ░██▄▄▄▄██░ ▓██▓ ░ ░██░▒██   ██░▓██▒  ▐▌██▒");
Console.WriteLine("          ▓█   ▓██▒▒▒█████▓   ▒██▒ ░ ░ ████▓▒░▒██▒   ░██▒ ▓█   ▓██▒ ▒██▒ ░ ░██░░ ████▓▒░▒██░   ▓██░");
Console.WriteLine("          ▒▒   ▓▒█░░▒▓▒ ▒ ▒   ▒ ░░   ░ ▒░▒░▒░ ░ ▒░   ░  ░ ▒▒   ▓▒█░ ▒ ░░   ░▓  ░ ▒░▒░▒░ ░ ▒░   ▒ ▒ ");
Console.WriteLine("           ▒   ▒▒ ░░░▒░ ░ ░     ░      ░ ▒ ▒░ ░  ░      ░  ▒   ▒▒ ░   ░     ▒ ░  ░ ▒ ▒░ ░ ░░   ░ ▒░");
Console.WriteLine("           ░   ▒    ░░░ ░ ░   ░      ░ ░ ░ ▒  ░      ░     ░   ▒    ░       ▒ ░░ ░ ░ ▒     ░   ░ ░ ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("               ░  ░   ░                  ░ ░         ░         ░  ░         ░      ░ ░           ░ ");
Console.WriteLine("       Antares        ");
Console.WriteLine("     [Version 1.0]                      Press Enter to begin...");
Console.ForegroundColor = originalColor;

var key = Console.ReadKey(true);
if (key.Key == ConsoleKey.Enter)
{
    Library library = new();
    Console.Clear();
    Console.WriteLine("Welcome to Library Automation System");

    while (true)
    {
        Console.WriteLine("\nMain Menu:");
        Console.WriteLine("1. Add a new Book");
        Console.WriteLine("2. Add a new Member");
        Console.WriteLine("3. Get the book list");
        Console.WriteLine("4. Get the member list");
        Console.WriteLine("5. Borrow a book");
        Console.WriteLine("6. Return a book");
        Console.WriteLine("7. Exit");
        Console.Write("\nSelect an option: ");

        var mainMenuKey = Console.ReadKey(true);
        Console.WriteLine();

        if (mainMenuKey.Key == ConsoleKey.D1 || mainMenuKey.Key == ConsoleKey.NumPad1)
        {
            Console.WriteLine("\nAdd Book Menu:");
            Console.WriteLine("1. A History Book");
            Console.WriteLine("2. A Novel");
            Console.WriteLine("3. A Science Book");
            Console.WriteLine("4. Return to main menu");
            Console.Write("\nSelect book type: ");

            var addBookMenu = Console.ReadKey(true);
            Console.WriteLine();

            Book newBook = null;

            if (addBookMenu.Key == ConsoleKey.D1 || addBookMenu.Key == ConsoleKey.NumPad1)
            {
                newBook = new BookHistory();
                Console.WriteLine("\nAdding a History Book:");
            }
            else if (addBookMenu.Key == ConsoleKey.D2 || addBookMenu.Key == ConsoleKey.NumPad2)
            {
                newBook = new BookNovel();
                Console.WriteLine("\nAdding a Novel:");
            }
            else if (addBookMenu.Key == ConsoleKey.D3 || addBookMenu.Key == ConsoleKey.NumPad3)
            {
                newBook = new BookScience();
                Console.WriteLine("\nAdding a Science Book:");
            }
            else if (addBookMenu.Key == ConsoleKey.D4 || addBookMenu.Key == ConsoleKey.NumPad4)
            {
                continue; // Return to main menu
            }
            else
            {
                Console.WriteLine("Invalid option. Returning to main menu.");
                continue;
            }

            // Collect book information
            if (newBook != null)
            {
                Console.Write("Enter book title: ");
                newBook.Title = Console.ReadLine() ?? string.Empty;

                Console.Write("Enter book description: ");
                newBook.Description = Console.ReadLine() ?? string.Empty;

                Console.Write("Enter author's first name: ");
                newBook.AuthorFirstName = Console.ReadLine() ?? string.Empty;

                Console.Write("Enter author's last name: ");
                newBook.AuthorLastName = Console.ReadLine() ?? string.Empty;

                Console.Write("Enter publisher: ");
                newBook.Publisher = Console.ReadLine() ?? string.Empty;

                bool validISBN = false;
                while (!validISBN)
                {
                    Console.Write("Enter ISBN number: ");
                    if (int.TryParse(Console.ReadLine(), out int isbnNumber))
                    {
                        newBook.ISBNNumber = isbnNumber;
                        validISBN = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid ISBN. Please enter a valid number.");
                    }
                }

                bool validStock = false;
                while (!validStock)
                {
                    Console.Write("Enter stock quantity: ");
                    if (int.TryParse(Console.ReadLine(), out int stockValue))
                    {
                        newBook.Stock = stockValue;
                        validStock = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock quantity. Please enter a valid number.");
                    }
                }

                bool validDate = false;
                while (!validDate)
                {
                    Console.Write("Enter published date (MM/DD/YYYY): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime publishedDate))
                    {
                        newBook.PublishedDate = publishedDate;
                        validDate = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format. Please use MM/DD/YYYY format.");
                    }
                }

                newBook.Status = Status.FitForBorrowing;

                library.AddBook(newBook);
                Console.WriteLine($"\nBook '{newBook.Title}' added successfully. ID: {newBook.Id}");
            }
        }
        else if (mainMenuKey.Key == ConsoleKey.D2 || mainMenuKey.Key == ConsoleKey.NumPad2)
        {
            Console.WriteLine("\nAdding a new Member:");

            Member newMember = new();

            Console.Write("Enter first name: ");
            newMember.FirstName = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter last name: ");
            newMember.LastName = Console.ReadLine() ?? string.Empty;

            bool validDate = false;
            while (!validDate)
            {
                Console.Write("Enter birthday (MM/DD/YYYY): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
                {
                    newMember.Birthday = birthday;
                    validDate = true;
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please use MM/DD/YYYY format.");
                }
            }

            library.AddMember(newMember);
            Console.WriteLine($"\nMember '{newMember.FirstName} {newMember.LastName}' added successfully. ID: {newMember.Id}");
        }
        else if (mainMenuKey.Key == ConsoleKey.D3 || mainMenuKey.Key == ConsoleKey.NumPad3)
        {
            Console.WriteLine("\nBook List:");

            if (library.Books.Count == 0)
            {
                Console.WriteLine("No books in the library.");
            }
            else
            {
                int counter = 1;
                foreach (var book in library.Books)
                {
                    string bookType = "";
                    if (book is BookHistory) bookType = "History";
                    else if (book is BookNovel) bookType = "Novel";
                    else if (book is BookScience) bookType = "Science";

                    Console.WriteLine($"{counter}. [{bookType}] {book.Title} by {book.AuthorFirstName} {book.AuthorLastName}");
                    Console.WriteLine($"   ID: {book.Id}");
                    Console.WriteLine($"   Publisher: {book.Publisher}, Published: {book.PublishedDate.ToShortDateString()}");
                    Console.WriteLine($"   Status: {book.Status}, Stock: {book.Stock}");
                    Console.WriteLine($"   ISBN: {book.ISBNNumber}");
                    Console.WriteLine();
                    counter++;
                }
            }
        }
        else if (mainMenuKey.Key == ConsoleKey.D4 || mainMenuKey.Key == ConsoleKey.NumPad4)
        {
            Console.WriteLine("\nMember List:");

            if (library.Members.Count == 0)
            {
                Console.WriteLine("No members in the library.");
            }
            else
            {
                int counter = 1;
                foreach (var member in library.Members)
                {
                    Console.WriteLine($"{counter}. {member.FirstName} {member.LastName}");
                    Console.WriteLine($"   ID: {member.Id}");
                    Console.WriteLine($"   Birthday: {member.Birthday.ToShortDateString()}");
                    Console.WriteLine($"   Membership Date: {member.MembershipDay.ToShortDateString()}");

                    if (member.BorrowedBooks.Count > 0)
                    {
                        Console.WriteLine($"   Borrowed Books ({member.BorrowedBooks.Count}):");
                        int bookCounter = 1;
                        foreach (var book in member.BorrowedBooks)
                        {
                            Console.WriteLine($"     {bookCounter}. {book.Title} (ID: {book.Id})");
                            bookCounter++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("   No books currently borrowed.");
                    }

                    Console.WriteLine();
                    counter++;
                }
            }
        }
        else if (mainMenuKey.Key == ConsoleKey.D5 || mainMenuKey.Key == ConsoleKey.NumPad5)
        {
            Console.WriteLine("\nBorrow a Book:");

            if (library.Members.Count == 0)
            {
                Console.WriteLine("No members in the library. Please add a member first.");
                continue;
            }

            if (library.Books.Count == 0 || !library.Books.Any(x => x.Stock > 0))
            {
                Console.WriteLine("No available books in the library. Please add a book first or renew the stocks.");
                continue;
            }

            // Display members
            Console.WriteLine("\nSelect a member:");
            int memberCounter = 1;
            foreach (var member in library.Members)
            {
                Console.WriteLine($"{memberCounter}. {member.FirstName} {member.LastName} (ID: {member.Id})");
                memberCounter++;
            }

            Console.Write("\nEnter member number: ");
            if (!int.TryParse(Console.ReadLine(), out int memberSelection) ||
                memberSelection < 1 || memberSelection > library.Members.Count)
            {
                Console.WriteLine("Invalid member selection.");
                continue;
            }

            Member selectedMember = library.Members.ElementAt(memberSelection - 1);

            // Display available books
            Console.WriteLine("\nSelect a book to borrow:");
            int bookCounter = 1;
            foreach (var book in library.Books)
            {
                if (book.Status == Status.FitForBorrowing)
                {
                    Console.WriteLine($"{bookCounter}. {book.Title} by {book.AuthorFirstName} {book.AuthorLastName} (ID: {book.Id})");
                }
                bookCounter++;
            }

            Console.Write("\nEnter book number: ");
            if (!int.TryParse(Console.ReadLine(), out int bookSelection) ||
                bookSelection < 1 || bookSelection > library.Books.Count)
            {
                Console.WriteLine("Invalid book selection.");
                continue;
            }

            Book selectedBook = library.Books.ElementAt(bookSelection - 1);

            selectedMember.BorrowBook(selectedBook);
        }
        else if (mainMenuKey.Key == ConsoleKey.D6 || mainMenuKey.Key == ConsoleKey.NumPad6)
        {
            Console.WriteLine("\nReturn a Book:");

            if (library.Members.Count == 0)
            {
                Console.WriteLine("No members in the library.");
                continue;
            }

            // Display members with borrowed books
            Console.WriteLine("\nSelect a member:");
            int memberCounter = 1;
            var membersWithBooks = library.Members.Where(m => m.BorrowedBooks.Count > 0).ToList();

            if (membersWithBooks.Count == 0)
            {
                Console.WriteLine("No members have borrowed books.");
                continue;
            }

            foreach (var member in membersWithBooks)
            {
                Console.WriteLine($"{memberCounter}. {member.FirstName} {member.LastName} (ID: {member.Id})");
                memberCounter++;
            }

            Console.Write("\nEnter member number: ");
            if (!int.TryParse(Console.ReadLine(), out int memberSelection) ||
                memberSelection < 1 || memberSelection > membersWithBooks.Count)
            {
                Console.WriteLine("Invalid member selection.");
                continue;
            }

            Member selectedMember = membersWithBooks[memberSelection - 1];

            // Display borrowed books
            Console.WriteLine($"\nSelect a book to return for {selectedMember.FirstName} {selectedMember.LastName}:");
            int bookCounter = 1;
            foreach (var book in selectedMember.BorrowedBooks)
            {
                Console.WriteLine($"{bookCounter}. {book.Title} by {book.AuthorFirstName} {book.AuthorLastName} (ID: {book.Id})");
                bookCounter++;
            }

            Console.Write("\nEnter book number: ");
            if (!int.TryParse(Console.ReadLine(), out int bookSelection) ||
                bookSelection < 1 || bookSelection > selectedMember.BorrowedBooks.Count)
            {
                Console.WriteLine("Invalid book selection.");
                continue;
            }

            Book selectedBook = selectedMember.BorrowedBooks.ElementAt(bookSelection - 1);

            selectedMember.ReturnBook(selectedBook);
        }
        else if (mainMenuKey.Key == ConsoleKey.D7 || mainMenuKey.Key == ConsoleKey.NumPad7)
        {
            Console.WriteLine("\nExiting Library Automation System. Goodbye!");
            break;
        }
        else
        {
            Console.WriteLine("Invalid option. Please try again.");
        }
    }
}