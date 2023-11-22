using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{

    public class Person
    {
        protected string name;
        protected string dob;
        protected string gender;
        protected string address;


        public Person()
        {
            this.getName();
            this.getDob();
            this.getGender();
            this.getAddress();

        }

        public Person(string name, string dob, string gender, string address)
        {
            this.name = name;
            this.dob = dob;
            this.gender = gender;
            this.address = address;

        }


        public void getName()
        {
            Console.WriteLine("Name:");
            name = Console.ReadLine();
        }

        private void getDob()
        {
            Console.WriteLine("Dob:");
            dob = Console.ReadLine();
        }

        private void getGender()
        {
            Console.WriteLine("Gender:");
            gender = Console.ReadLine();
        }

        private void getAddress()
        {
            Console.WriteLine("Address:");
            address = Console.ReadLine();
        }

        public void displayUser()
        {

            Console.WriteLine("Name: " + this.name + "\n "
                   + "Address: " + this.address + "\n "
                   + "dob: " + this.dob + "\n "
                   + "Gender: " + this.gender + "\n ");
        }
    }

}

