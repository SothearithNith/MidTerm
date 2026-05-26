using MidTerm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    internal class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public string TypeOfBook { get; set; }
        public Books()
        {

        }
        public Books(string title, string typeofbook, string author)
        {
            Title = title;
            Author = author;
            TypeOfBook = typeofbook;
        }

        string? title;
        string? type;
        string? author;
        int s;

        int total()
        {
            return s; 
        }
        public void input() 
        {
            Console.Write("\n\t\t------------------------------------------\n");
            Console.Write("\t\t               List Books\n");
            Console.Write("\t\t------------------------------------------\n");
            Console.Write("\n\t\t     + Input title of book  : ");
            title = Console.ReadLine();
            Console.Write("\n\t\t     + Input type of book   : ");
            type= Console.ReadLine();
            Console.Write("\n\t\t     + Input Author of book : ");
            author = Console.ReadLine();
            Console.Write("\n\t\t------------------------------------------");
            Console.Write("\n\t\t               Thank you");
            Console.Write("\n\t\t------------------------------------------");

        }

        public void output() 
        {
            Console.Write("\n\t\t------------------------------------------");
            Console.Write("\n\t\t             Data Books");
            Console.Write("\n\t\t------------------------------------------");
            Console.Write("\n\t\t     + The title of book is : " + title);
            Console.Write("\n\n\t\t     + The type of book is  : " + type);
            Console.Write("\n\n\t\t     + Author book by       : " + author);
            Console.Write("\n\t\t------------------------------------------");
            Console.Write("\n\t\t               Thank you");
            Console.Write("\n\t\t------------------------------------------");
        }

        public void insert()
        {
            Console.Write("\nInput qty books that you want to choose : ");
            s = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                input();
            }
            Console.Write("\nPlease enter 'Y' back to menu and any key to use option 1 again !!!!!");
            
        }
        public void view()
        {
            Console.Write("\n\n\t\t     Total book in library : " + total());
            for (int i = 0; i < s; i++)
            {
                output();
            }
            
            Console.Write("\nPlease enter 'Y' back to menu and any key to use option 2 again !!!!!");
        }
    }
}

