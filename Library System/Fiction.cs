using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Fiction : Book
    {

        protected string theme;

        public Fiction()
        {
            this.getTheme();


        }

        public Fiction(string theme)
        {

            this.theme = theme;

        }


        private void getTheme()
        {
            Console.WriteLine("Theme:");
            theme = Console.ReadLine();
        }



        public void displayBook()
        {

            Console.WriteLine("Book ID: " + this.bookID + "\n "
                   + "Title: " + this.title + "\n "
                   + "Theme: " + this.theme + "\n "
                   + "Author: " + this.author + "\n "
                   + "Copies available: " + this.copies + "\n ");
        }
    }
}
