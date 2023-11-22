using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Book
    {
        public int bookID;
        protected string author;
        protected string title;
        protected int copies;


        public Book()
        {
            this.getBookID();
            this.getAuthor();
            this.getTitle();
            this.getCopies();

        }

        public Book(int bookID, string author, string title, int copies)
        {
            this.bookID = bookID;
            this.author = author;
            this.title = title;
            this.copies = copies;

        }


        public void getBookID()
        {
            Console.WriteLine("Book ID:");
            bookID = Convert.ToInt32(Console.ReadLine());
        }

        private void getAuthor()
        {
            Console.WriteLine("Author:");
            author = Console.ReadLine();
        }

        private void getTitle()
        {
            Console.WriteLine("Title:");
            title = Console.ReadLine();
        }

        private void getCopies()
        {
            Console.WriteLine("Copies:");
            copies = Convert.ToInt32(Console.ReadLine());
        }

        public void displayBook()
        {

            Console.WriteLine("Book ID: " + this.bookID + "\n "
                   + "Title: " + this.title + "\n "
                   + "Author: " + this.author + "\n "
                   + "Copies available: " + this.copies + "\n ");
        }

        public void withdrawBook()
        {
            if (copies > 0)
            {
                copies = copies -1;
                Console.WriteLine("There are: " + copies + " copies of " + title + " now\n ");
            }
            else
            {
                Console.WriteLine("There are no copies of "+title+" left\n");
            }
        }

        public void returnBook()
        {
            copies = copies + 1;
            Console.WriteLine("There are: " + copies + " copies of " +title+ " now\n ");
        }

    }
}
