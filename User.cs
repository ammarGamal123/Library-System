using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class User
    {
        private int id;
        private string name;
        private string email;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }  


        internal void addUser() { }
        internal void userBorrowBook() { }
        internal void userReturnBook() { }
        internal void displayUsers() { }



        public override string ToString()
        {
            return $"ID = {id} , Name = {name} , Email = {email}";
        }

    }
}
