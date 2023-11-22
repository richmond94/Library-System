using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    

        public class Librarian : Person
        {

            protected int staffID;

            public Librarian()
            {

                this.getStaffID();

            }

            public Librarian(int staffID)
            {

                this.staffID =staffID;

            }

            private void getStaffID()
            {
                Console.WriteLine("Member ID:");
                staffID = Convert.ToInt32(Console.ReadLine());
            }

            public void displayUser()
            {

                Console.WriteLine("Staff ID: " + this.staffID + "\n "
                       + "Name: " + this.name + "\n "
                       + "Address: " + this.address + "\n "
                       + "dob: " + this.dob + "\n "
                       + "Gender: " + this.gender + "\n ");
            }















        }


    }

