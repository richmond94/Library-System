using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Member : Person
    {

        protected int memberID;

        public Member()
        {

            this.getMemberID();

        }

        public Member(int memberID)
        {

            this.memberID = memberID;

        }

        private void getMemberID()
        {
            Console.WriteLine("Member ID:");
            memberID = Convert.ToInt32(Console.ReadLine());
        }

        public void displayUser()
        {

            Console.WriteLine("Member ID: " + this.memberID + "\n "
                   + "Name: " + this.name + "\n "
                   + "Address: " + this.address + "\n "
                   + "dob: " + this.dob + "\n "
                   + "Gender: " + this.gender + "\n ");
        }















    }

}
