using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class NonFiction : Book
    {

        protected string topic;

        public NonFiction()
        {
            this.getTopic();
            

        }

        public NonFiction(string topic)
        {
           
            this.topic = topic;

        }


        private void getTopic()
        {
            Console.WriteLine("Topic:");
            topic = Console.ReadLine();
        }

       

        public void displayBook()
        {

            Console.WriteLine("Book ID: " + this.bookID + "\n "
                   + "Title: " + this.title + "\n "
                   + "Topic: " + this.topic + "\n "
                   + "Author: " + this.author + "\n "
                   + "Copies available: " + this.copies + "\n ");
        }












    }
}
