using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Book
    {
        private int id;
        private string name;
        private int quantity;



        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        

        static List<int> idList = new List<int>();
        static List<string> nameList = new List<string>();
        static HashSet<int> idSet = new HashSet<int>();
        static HashSet<string> nameSet = new HashSet<string>();
        // this is list of tuples , each tuple continains (int idUser , string nameUser)
        static List <(int, string)> both = new List<(int, string)>();

        internal void addBook ()
        {
            int idUser;
            
            int quantityUser;

            do
            {
                Console.WriteLine("Enter Book ID:");
            } while (!int.TryParse(Console.ReadLine(), out idUser));

            Console.WriteLine("Enter Book Name:");
            
            string nameUser = Console.ReadLine();

            do
            {
                Console.WriteLine("Enter Book Quantity:");
            } while (!int.TryParse(Console.ReadLine(),out quantityUser));
            
            
            if (!idSet.Contains(id) && !nameSet.Contains(nameUser))
            {
                idSet.Add(idUser);
                nameSet.Add(nameUser);
                idList.Add(idUser);
                nameList.Add(nameUser);
               
                var val = (idUser, nameUser);
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
        internal void searchBook()
        {
            Console.WriteLine("Enter Book Name:");
            string word = Console.ReadLine();
            List<string> searchResults = new List<string>();
            
            
                bool check = true;
            for (int i = 0; i < nameList?.Count; i++)
            {
                if (word?.Length <= nameList[i].Length)
                {
                    check = true;
                    for (int j = 0; j < word?.Length; j++)
                    {
                        check &= nameList[i][j] == word[j];
                    }
                    if (check)
                    {
                        searchResults.Add(nameList[i]);
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
        internal void displayUsersBorrowBooks()
        {

        }
        internal void displayBooksByID()
        {

        }
        internal void displayBooksByNames()
        {
            for (int i = 0;i < nameList?.Count;i++)
            {
                Console.WriteLine(nameList[i]);
            }
        }
        






        // display attributes
        public override string ToString()
        {
            return $"ID = {id} , Name {name} , Quantity {quantity}";
        }
    }
}
