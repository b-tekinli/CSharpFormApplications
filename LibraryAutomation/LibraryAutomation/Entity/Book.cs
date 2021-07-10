using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAutomation.Entity
{
    public class Book
    {
        public int bookID { get; set; }
        public string bookName { get; set; }
        public string Writer { get; set; }
        public string bookLanguage { get; set; }
        public string publisher { get; set; }
        public string bookKind { get; set; }
        public int piece { get; set; }
        public int numberOfPages { get; set; }
        public int yearOfPublication { get; set; }


        public Book()
        {

        }


        // bu yapıcı constructor'ı kullanarak set edeceğimiz için setter metodlarını yazmadık.
        public Book(int bookID, string bookName, string Writer, string bookLanguage, string publisher, string bookKind, int piece, int numberOfPages, int yearOfPublication)
        {
            this.bookID = bookID;
            this.bookName = bookName;
            this.Writer = Writer;
            this.bookLanguage = bookLanguage;
            this.publisher = publisher;
            this.bookKind = bookKind;
            this.piece = piece;
            this.numberOfPages = numberOfPages;
            this.yearOfPublication = yearOfPublication;
        }

        public int getBookID()
        {
            return this.bookID;
        }

        public string getBookName()
        {
            return this.bookName;
        }

        public string getWriter()
        {
            return this.Writer;
        }

        public string getBookLanguage()
        {
            return this.bookLanguage;
        }

        public string getPublisher()
        {
            return this.publisher;
        }

        public string getBookKind()
        {
            return this.bookKind;
        }

        public int getPiece()
        {
            return this.piece;
        }

        public int getNumberOfPages()
        {
            return this.numberOfPages;
        }

        public int getyearOfPublication()
        {
            return this.yearOfPublication;
        }
    }
}
