using LibraryAutomation.Base.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Base.Entities.Concrete
{
    public class Library
    {
        public ICollection<Member> Members { get; set; } = new HashSet<Member>();
        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
        public ICollection<Member> AddMember(Member member)
        {
            Members.Add(member);
            return Members;
        }
        public ICollection<Member> RemoveMember(Member member)
        {
            if (member.BorrowedBooks.Count > 0)
            {
                Console.WriteLine($"{member.FirstName} {member.LastName} can't be deleted due to having borrowed books. Member Id: {member.Id}");
                return Members;
            }
            Members.Remove(member);
            Console.WriteLine($"{member.FirstName} {member.LastName} deleted successfully. Member Id: {member.Id}");
            return Members;
        }
        public ICollection<Book> AddBook(Book book)
        {
            Books.Add(book);
            return Books;
        }
        public ICollection<Book> RemoveBook(Book book)
        {
            Books.Remove(book);
            return Books;
        }
    }
}
