using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MidTerm.Books;

namespace MidTerm
{

    internal class Library
    {
        private Books[] books = new Books[100];
        private int bookcount = 0;
        private Magazine[] magazines = new Magazine[100];
        private int magazinecount = 0;
        public Library() { }

        public void AddBook(Books book)
        {
            books[bookcount] = book;
            bookcount++;
        }
        public void AddMagazine(Magazine magazine)
        {
            magazines[magazinecount] = magazine;
            magazinecount++;
        }
        public int GetTotalBook()
        {
            return bookcount;
        }
        public int GetTotalMagazine()
        {
            return magazinecount;
        }

        public void PrintAllBook()
        {
            Console.Write("\n\t\t\t    -----------------------------------------\n");
            Console.Write("\t\t\t                Book in Library \n");
            Console.Write("\t\t\t    -----------------------------------------\n");
            for (int i = 0; i < bookcount; i++)
            {
                Console.WriteLine($"\n\t\t\tNo:{i + 1}, Title: {books[i].Title}, Author: {books[i].Author}");
            }
            Console.Write("\n\t\t\t    -------------------------------------------------------------\n");
            Console.Write("\t\t\t                           Thank you \n");
            Console.Write("\t\t\t    -------------------------------------------------------------\n");
        }
        public void PrintAllMagazine()
        {
            Console.Write("\n\t\t\t    -------------------------------------------------------------\n");
            Console.Write("\t\t\t                        Magazine in Library \n");
            Console.Write("\t\t\t    -------------------------------------------------------------\n");
            for (int i = 0; i < magazinecount; i++)
            {
                Console.WriteLine($"\n\t\tNo:{i + 1}, Title:{magazines[i].MagazineTitle}, Categories:{magazines[i].Categories}, Company:{magazines[i].MagazineCompany}");
            }
            Console.Write("\n\t\t\t    -------------------------------------------------------------\n");
            Console.Write("\t\t\t                           Thank you \n");
            Console.Write("\t\t\t    -------------------------------------------------------------\n");
        }
    }
}
