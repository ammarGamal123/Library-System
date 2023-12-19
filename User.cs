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
        
        
        
        // Completed
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
                Console.WriteLine("The User Added Successfully\n");
            }
            else
            {
                Console.WriteLine("Either the id or book name or email already existed\n");
            }


            byte choice;
            Console.WriteLine("*************************************\n");
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






        // Completed
        internal void userBorrowBook()
        {
            Console.WriteLine("Enter User Name");
            string userBorrowName = Console.ReadLine();

            
            
            Console.WriteLine("Here is a list of available books: \n");

            for (int i = 0; i < Book.nameBookList?.Count; i++)
            {
                Console.WriteLine(Book.nameBookList[i]);
            }
            
            
            Console.WriteLine("Enter Book Name\n\n");
            string bookBorrowName = Console.ReadLine();
            

            if (nameUserSet.Contains(userBorrowName) && Book.nameBookSet.Contains(bookBorrowName))
            {
                if (Book.quantitBookMap[bookBorrowName] > 0)
                {
                    Book.quantitBookMap[bookBorrowName]--;
                    Console.WriteLine($"User {userBorrowName} borrowed successfully\n\n");
                }
                else
                {
                    Console.WriteLine("The book is not valid\n");
                }
            }
            else
            {
                Console.WriteLine("Sorry please enter valid user name and book name\n");
            }
            
            byte choice;
            Console.WriteLine("***************************************\n");
            Console.WriteLine("1) Add another user to borrow another book");
            Console.WriteLine("2) Back\n");

            do
            {
                Console.WriteLine("Enter Choice");
            } while (!byte.TryParse(Console.ReadLine(), out choice));

            if (choice == 1)
            {
                userBorrowBook();
            }
            else
            {
                Menu menu = new Menu();
                menu.Menu1();
            }
            
        }


    
        
        // Completed
        internal void userReturnBook()
        {
            Console.WriteLine("Enter User Name :");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter Book Name :");
            string bookName = Console.ReadLine();


            if (nameUserSet.Contains(userName) && Book.nameBookSet.Contains(bookName))
            {
                Book.quantitBookMap[bookName] += 1;
                Console.WriteLine("The book returned successfully\n");
            }
            else
            {
                Console.WriteLine("Either the user name or book name is not correct\n");
            }
            
            
            
            Console.WriteLine("1) Return another book ");
            Console.WriteLine("2) Back\n");
            
            byte choice;
            do
            {
                Console.WriteLine("Enter choice\n");
            } while (!byte.TryParse(Console.ReadLine(), out choice));

            if (choice == 1)
            {
                userReturnBook();
            }
            else
            {
                Menu menu = new Menu();
                menu.Menu1();
            }
        }
        
        
        
        // Completed
        internal void displayUsers()
        {
            for (int i = 0; i < nameUserList?.Count; i++)
            {
                Console.WriteLine($"Name: {nameUserList[i]} , ID: {idUserList[i]} , Email: {emailUserList[i]} ");
            }

            byte choice;
            Console.WriteLine("1) Display Users one more time");
            Console.WriteLine("2) Back");

            do
            {
                Console.WriteLine("Enter choice\n");
            } while (!byte.TryParse(Console.ReadLine(), out choice));

            if (choice == 1)
            {
                displayUsers();
            }
            else
            {
                Menu menu = new Menu();
                menu.Menu1();
            }
        }



        public override string ToString()
        {
            return $"ID = {id} , Name = {name} , Email = {email}";
        }

    }
}
