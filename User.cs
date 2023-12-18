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

        public static List<string> nameUserList = new List<string>();
        public static List<int> idUserList = new List<int>();
        public static List<string> emailUserList = new List<string>();

        public static HashSet<int> idUserSet = new HashSet<int>();
        public static HashSet<string> nameUserSet = new HashSet<string>();
        public static HashSet<string> emailUserSet = new HashSet<string>();
        
        
        internal void addUser()
        {
            int idUser;
            
            do
            {
                Console.WriteLine("Enter User ID :");
            } while (!int.TryParse(Console.ReadLine(), out idUser));

            Console.WriteLine("Enter User Name :");
            string nameUser = Console.ReadLine();

            Console.WriteLine("Enter Your Email:");
            string emailUser = Console.ReadLine();

            if (!idUserSet.Contains(idUser) &&
                !nameUserSet.Contains(nameUser) &&
                !emailUserSet.Contains(emailUser))
            {
                idUserSet.Add(idUser);
                nameUserSet.Add(nameUser);
                emailUserSet.Add(emailUser);

                idUserList.Add(idUser);
                nameUserList.Add(nameUser);
                emailUserList.Add(emailUser);
            }
            else
            {
                Console.WriteLine("Either the id or book name or email already existed");
            }


            byte choice;
            Console.WriteLine("*********************************");
            Console.WriteLine("1) Add Another User:");
            Console.WriteLine("2) Back");

            do
            {
                Console.WriteLine("Enter Choice");
            } while (!byte.TryParse(Console.ReadLine(), out choice));

            if (choice == 1)
            {
                addUser();
            }
            else
            {
                Menu menu = new Menu();
                menu.Menu1();
            }

        }







        internal void userBorrowBook()
        {
            Console.WriteLine("Enter User Name");
            string userBorrowName = Console.ReadLine();
            
            
            Console.WriteLine("Enter Book Name");
            string bookBorrowName = Console.ReadLine();

            if (nameUserSet.Contains(userBorrowName) && Book.nameBookList.Contains(bookBorrowName))
            {
                if (Book.quantitBookMap[bookBorrowName] > 0)
                {
                    Book.quantitBookMap[bookBorrowName]--;
                }
                else
                {
                    Console.WriteLine("The book is not valid");
                }
            }
            else
            {
                Console.WriteLine("Sorry please enter valid user name and book name");
            }
            
            byte choice;
            Console.WriteLine("*********************************");
            Console.WriteLine("1) Add Another User:");
            Console.WriteLine("2) Back");

            do
            {
                Console.WriteLine("Enter Choice");
            } while (!byte.TryParse(Console.ReadLine(), out choice));

            if (choice == 1)
            {
                addUser();
            }
            else
            {
                Menu menu = new Menu();
                menu.Menu1();
            }
            
        }
        internal void userReturnBook() { }
        internal void displayUsers() { }



        public override string ToString()
        {
            return $"ID = {id} , Name = {name} , Email = {email}";
        }

    }
}
