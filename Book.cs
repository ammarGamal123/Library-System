using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Book
    {
        private int id;
        private string name;
        private int quantity;



        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        

        public static List<int> idList = new List<int>();
        public static List<string> nameBookList = new List<string>();
        public static List<int> quantList = new List<int>();
        public static HashSet<int> idSet = new HashSet<int>();
        public static HashSet<string> nameSet = new HashSet<string>();
        // this is list of tuples , each tuple continains (int idBook , string nameBook)
        public static List <(int, string)> both = new List<(int, string)>();
        public static Dictionary<string, int> quantitBookMap = new Dictionary<string , int>();
        
        // Completed
        internal void addBook ()
        {
            int idBook;
            
            int quantBook;

            do
            {
                Console.WriteLine("Enter Book ID:");
            } while (!int.TryParse(Console.ReadLine(), out idBook));

            Console.WriteLine("Enter Book Name:");
            
            string nameBook = Console.ReadLine();

            do
            {
                Console.WriteLine("Enter Book Quantity:");
            } while (!int.TryParse(Console.ReadLine(),out quantBook));
            
            
            if (!idSet.Contains(id) && !nameSet.Contains(nameBook))
            {
                idSet.Add(idBook);
                nameSet.Add(nameBook);
                idList.Add(idBook);
                nameBookList.Add(nameBook);
                quantList.Add(quantBook);
                quantitBookMap[nameBook] ++;
                var val = (idBook, nameBook);
                both.Add(val);

                Console.WriteLine("Added Succefully\n");
            }
            else
            {
                Console.WriteLine("Either the id or book name already existed");
            }

            byte choice;

            Console.WriteLine("**********************************\n");
            Console.WriteLine("1) Add Another Book");
            Console.WriteLine("2) Back");

            do
            {
                Console.WriteLine("Enter a Choice :");
            } while (!byte.TryParse(Console.ReadLine(), out choice));

            if (choice == 1)
            {
                addBook();
            }
            else
            {
                Menu menu = new Menu();
                menu.Menu1();
            }
        }
        
        
        // Completed
        internal void searchBook()
        {
            Console.WriteLine("Enter Book Name:");
            string word = Console.ReadLine();
            List<string> searchResults = new List<string>();
            
            
            bool check = true;
            for (int i = 0; i < nameBookList?.Count; i++)
            {
                if (word?.Length <= nameBookList[i].Length)
                {
                    check = true;
                    for (int j = 0; j < word?.Length; j++)
                    {
                        check &= nameBookList[i][j] == word[j];
                    }
                    if (check)
                    {
                        searchResults.Add(nameBookList[i]);
                    }
                }
            }
            

            Menu menu = new Menu();
            if (searchResults.Count > 0)
            {
                for (int i = 0;i < searchResults?.Count;i++)
                {
                    Console.WriteLine(searchResults[i]);
                }
            }
            else
            {
                Console.WriteLine("No such prefix matches any books");
            }
            byte choice;
            do
            {
                Console.WriteLine("Enter choice:");
                Console.WriteLine("1) Search one more time");
                Console.WriteLine("2) Back");

            }while (!byte.TryParse(Console.ReadLine(), out choice));

            Book book = new Book();
            if (choice == 1) {
                book.searchBook();
            }
            else
            {
                menu.Menu1();
            }

        }
        
        
        // Not Completed Yet
        internal void displayUsersBorrowBooks()
        {
            
        }
        
        
        
        internal void displayBooksByID()
        {
            for (int i = 0; i < idList?.Count(); i++)
            {
                Console.WriteLine($"{i + 1}) {idList[i]}");
            }
            

            byte choice;
            do
            {
                Console.WriteLine("Enter choice:");
                Console.WriteLine("1) Display book ID more time");
                Console.WriteLine("2) Back");

            }while (!byte.TryParse(Console.ReadLine(), out choice));

            Menu menu = new Menu();
            Book book = new Book();
            
            
            if (choice == 1) {
                book.displayBooksByID();
            }
            else
            {
                menu.Menu1();
            }
        }
        
        
        // Completed
        internal void displayBooksByNames()
        {
            for (int i = 0; i < nameBookList?.Count(); i++)
            {
                Console.WriteLine($"{i + 1}) {nameBookList[i]}");
            }
            

            byte choice;
            do
            {
                Console.WriteLine("Enter choice:");
                Console.WriteLine("1) Display book names one more time");
                Console.WriteLine("2) Back");

            }while (!byte.TryParse(Console.ReadLine(), out choice));

            Menu menu = new Menu();
            Book book = new Book();
            
            
            if (choice == 1) {
                book.displayBooksByNames();
            }
            else
            {
                menu.Menu1();
            }
            
        }
        


        // display attributes
        public override string ToString()
        {
            return $"ID = {id} , Name {name} , Quantity {quantity}";
        }
    }
}
