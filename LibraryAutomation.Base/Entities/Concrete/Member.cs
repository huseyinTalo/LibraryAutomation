using LibraryAutomation.Base.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Base.Entities.Concrete
{
    public class Member : IMember
    {
        public Guid Id { get; } = Guid.NewGuid();

        private string _firstName = string.Empty;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _firstName = string.Empty;
                }
                else
                {
                    string trimmed = value.Trim().Replace(" ", "");
                    _firstName = char.ToUpper(trimmed[0]) + trimmed[1..].ToLower();
                }
            }
        }
        private string _lastName = string.Empty;
        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _lastName = string.Empty;
                }
                else
                {
                    string trimmed = value.Trim().Replace(" ", "");
                    _lastName = char.ToUpper(trimmed[0]) + trimmed[1..].ToLower();
                }
            }
        }
        public DateTime MembershipDay { get; } = DateTime.Now;
        public DateTime Birthday { get; set; }
        public ICollection<Book> BorrowedBooks { get; set; } = new HashSet<Book>();
        public ICollection<Book> BorrowBook(Book book)
        {
            if (book.Status == Utilities.Status.FitForBorrowing)
            {
                if (book.Stock > 0)
                {
                    book.Stock--;
                    BorrowedBooks.Add(book);
                    Console.WriteLine($"{book.Title} borrowed successfully");
                    return BorrowedBooks;
                }

                book.Status = Utilities.Status.OutOfStock;
                Console.WriteLine($"{book.Title} out of stock");
            }

            Console.WriteLine($"{book.Title} can't be borrowed");
            return BorrowedBooks;
        }

        public ICollection<Book> ReturnBook(Book book)
        {
            book.Stock++;
            book.Status = Utilities.Status.FitForBorrowing;
            BorrowedBooks.Remove(book);
            Console.WriteLine($"{book.Title} returned successfully");
            return BorrowedBooks;
        }
    }
}
