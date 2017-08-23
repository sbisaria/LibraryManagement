using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
//        Library Management System

//        Provide a solution for the library to issue books.

//        The library has different genres of books like fiction, technical, horror etc.

//        Write a program to issue a book from the library and list down all the books issued by the library.

//        Instructions
//        1. Do not use console application.
//        2. Write all the possible test cases.
//3. No need to include a person to issue books in the solution.
        public string Name { get; set; }
        public string Id { get; set; }
        public string Author { get; set; }
        public Genere BookGenere { get; set; }
        public string IssueStatus { get; set; }
        public string Publication { get; set; }
        public string Edition { get; set; }
        public int BookCount { get; set; }

        public override string ToString()
        {
            var str = new StringBuilder();
            var name = $"Book Name : {Name}";
            var id = $"Book Id : {Id}";
            var author = $"Author Name : {Author}";
            var issueStatus = $"Issue Status : {IssueStatus}";
            var publication = $"Publication : {Publication}";
            var edition = $"Edition : {Edition}";

            str.Append(name).Append("\n").Append(id).Append("\n").Append(author).Append("\n").Append(issueStatus).Append("\n").Append(publication).Append("\n").Append(edition).Append("\n");
            return str.ToString();

        }
    }
}
