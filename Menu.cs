using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Menu
    {

        public Menu() { }
        public void Menu1()
        {
            byte choice;
            

            do
            {

                Console.WriteLine("*********************");

                Console.WriteLine("Library Menu:");
                Console.WriteLine("1) Add book");
                Console.WriteLine("2) Search books by prefix");
                Console.WriteLine("3) Print who borrows books by name");
                Console.WriteLine("4) Print books by ID");
                Console.WriteLine("5) Print books by name");
                Console.WriteLine("6) Add user");
                Console.WriteLine("7) User borrows books");
                Console.WriteLine("8) User returns books");
                Console.WriteLine("9) Print Users");
                Console.WriteLine("10) Exit\n");

                Console.WriteLine("Enter Choice [1 - 10]:");

            } while (!byte.TryParse(Console.ReadLine(), out choice));
            Menu2(choice);
        }


        public void Menu2(byte choice)
        {
            Book b = new Book();
            User u = new User();
            
            
            switch (choice) {
                case 1:
                    b.addBook();
                break;

                case 2:
                    b.searchBook();
                break;
                
                case 3:
                    b.displayUsersBorrowBooks();
                    break;

                case 4:
                    b.displayBooksByID();
                    break;

                case 5:
                    b.displayBooksByNames();
                    break;

                case 6:
                    u.addUser();
                    break;
                case 7:
                    u.userBorrowBook();
                    break;
                case 8:
                    u.userReturnBook();
                    break;
                case 9:
                    u.displayUsers();
                    break;
                case 10:
                    Console.WriteLine("Thank you for using my app");
                    break;

                default:
                    Console.WriteLine("Not Here");
                break;
            }
        }
        
        
        
    }
}
