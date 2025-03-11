using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Base.Entities.Abstract
{
    public interface IMember
    {
        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime MembershipDay { get; }
        public DateTime Birthday { get; set; }
        public ICollection<Book> BorrowBook(Book book);
        public ICollection<Book> ReturnBook(Book book);
    }
}
