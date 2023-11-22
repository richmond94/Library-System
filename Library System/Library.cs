using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Library
    {
        private string libraryName;
        private string libraryAddress;
        private long libraryNumber;


        public Library()
        {
            this.getLibraryName();
            this.getLibraryAddress();
            this.getLibraryNumber();

        }

        public Library(string libraryName, string libraryAddress, long libraryNumber)
        {
            this.libraryName = libraryName;
            this.libraryAddress = libraryAddress;
            this.libraryNumber = libraryNumber;

        }


        public void getLibraryName()
        {
            Console.WriteLine("Enter Make:");
            libraryName = Console.ReadLine();
        }

        private void getLibraryAddress()
        {
            Console.WriteLine("Enter Model:");
            libraryAddress = Console.ReadLine();
        }


        private void getLibraryNumber()
        {
            Console.WriteLine("How Much Fuel:");
            libraryNumber = Convert.ToInt32(Console.ReadLine());
        }

        public void displayLibrary()
        {

            Console.WriteLine("Name: " + this.libraryName + "\n "
                   + "Address: " + this.libraryAddress + "\n "
                   + "Number: " + this.libraryNumber + "\n ");
        }
    }

}