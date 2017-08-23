using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        public List<Book> Books { get; set; } 
        public List<string> IssuedBooks { get; set; }

        public string DisplayBookDetails()
        {
            var books = new Book();
            return (books.ToString());
        }
        public bool IssueBook(Book book)
        {
            IssuedBooks.Add("");
            return true;
        }
        public bool ReturnBook()
        {
            return true;
        }
    }
}
