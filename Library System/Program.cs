using Library_System;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
int choice;

Library library = new Library("Thurso Library", "Thurso Library/Davidson's La, Davidson's Ln, Thurso KW14 7AF", 12345678901);
Console.WriteLine("You are the new librarian, enter your details.\n");
Librarian librarian = new Librarian();
List<Member> memberList = new List<Member>();
List<Book> bookList = new List<Book>();
    



while (true)
{
    Console.WriteLine("Library System\n");
    Console.WriteLine("1. Display Library\n");
    Console.WriteLine("2. Display Librarian\n");
    Console.WriteLine("3. Create User\n");
    Console.WriteLine("4. Display Users\n");
    Console.WriteLine("5. Create book\n");
    Console.WriteLine("6. Display Books\n");
    Console.WriteLine("7. Withdraw books\n");
    Console.WriteLine("8. Return books\n");
    Console.WriteLine("9. Exit\n");
    Console.WriteLine("\nEnter Your Choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:

            library.displayLibrary();

            break;

        case 2:

            librarian.displayUser();

            break;

        case 3:

            memberList.Add(new Member());

            break;

        case 4:

            foreach (Member member in memberList)
            {
                member.displayUser();
            }

            break;

        case 5:

           int choice2;
            Console.WriteLine("What type of book?\n");
            Console.WriteLine("1. Fiction Book\n");
           Console.WriteLine("2. Non-Fiction Book\n");
           choice2 = Convert.ToInt32(Console.ReadLine());

           if(choice2 == 1)
            {

                bookList.Add(new Fiction());

            }
           else
            {

                bookList.Add(new NonFiction());

            }

            break;

        case 6:

            foreach (Book book in bookList)
            {
                book.displayBook();
            }


            break;

        case 7:

            
            foreach (Book book in bookList)
            {
                book.withdrawBook();
            }




            break;

        case 8:

            foreach (Book book in bookList)
            {
                book.returnBook();
            }

            break;

        case 9:
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Invalid Option");
            break;
    }




}


