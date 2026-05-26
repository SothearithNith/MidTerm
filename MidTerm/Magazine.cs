using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm
{
    internal class Magazine
    {
        public string MagazineTitle { get; set; }

        public string MagazineCompany { get; set; }
        public string Categories { get; set; }

        public Magazine()
        {

        }
        public Magazine(string magazinetitle, string categories, string magazinecompany)
        {
            MagazineTitle = magazinetitle;
            Categories = categories;
            MagazineCompany = magazinecompany;
        }

        string? companyName;
        string? magazineTitle;
        string? magazineType;
        public int a;

        int Total()
        {
            return a;
        }
        public void input()
        {
            Console.Write("\n\t\t------------------------------------------\n");
            Console.Write("\t\t               List Magazine\n");
            Console.Write("\t\t------------------------------------------\n");
            Console.Write("\n\t\t + Input Company name        : ");
            companyName = Console.ReadLine();
            Console.Write("\n\t\t + Input Magazine of Title   : ");
            magazineTitle = Console.ReadLine();
            Console.Write("\n\t\t + Input Magazine of Type    : ");
            magazineType = Console.ReadLine();
            Console.Write("\n\t\t------------------------------------------");
            Console.Write("\n\t\t               Thank you");
            Console.Write("\n\t\t------------------------------------------");
        }

        public void output() 
        {
            Console.Write("\n\t\t------------------------------------------\n");
            Console.Write("\t\t               Data Magazine\n");
            Console.Write("\t\t------------------------------------------\n");
            Console.Write("\n\t\t + Name of company   : " + companyName);
            Console.Write("\n\n\t\t + Magazine of Title : " + magazineTitle);
            Console.Write("\n\n\t\t + Magazine of Type  : " + magazineType);
            Console.Write("\n\t\t------------------------------------------");
            Console.Write("\n\t\t               Thank you");
            Console.Write("\n\t\t------------------------------------------");
        }

        public void insert()
        {
            Console.Write("\nInput qty books that you want to choose : ");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                input();
            }
            Console.Write("\nPlease enter 'Y' back to menu and any key to use option 3 again !!!!!");
        }
        public void view()
        {
            Console.Write("\n\n\t\t     Total book in library : " + Total());
            for (int i = 0; i < a; i++)
            {
                output();
            }
            Console.Write("\nPlease enter 'Y' back to menu and any key to use option 4 again !!!!!");
        }
    }
}
