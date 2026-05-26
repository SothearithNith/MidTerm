using MidTerm;
using System.ComponentModel.Design;

//------------------------
Books books = new Books();
Magazine magazine = new Magazine();
Library library = new Library();
back:
//----------------------------------------
Books b1 = new Books("Basic C#", "Mr. Ngut Viravud", "Computer programing");
Books b2 = new Books("Harry Potter", "Ms. J.K Rowling", "Novel");
Books b3 = new Books("Angkor Khmer and the Civilization", "Mr. Michael D.Code and Mr. Damain Evans", "History");
//--------------------------------------------
Magazine l1 = new Magazine("Ronaldo is GAOT of football", "football", "Fabrizio Romano");
Magazine l2 = new Magazine("Real Madrid is best clue", "football", "Fabrizio Romano");
Magazine l3 = new Magazine("Barcelona just a small team", "football", "Fabrizio Romano");
//--------------------------------------------
int n;
Console.Write("\t\t-----------------------------------------\n");
Console.Write("\t\t             Menu Library\n");
Console.Write("\t\t-----------------------------------------\n");
Console.Write("\n\t\t        + 1. Insert Books\n");
Console.Write("\n\t\t        + 2. View Books\n");
Console.Write("\n\t\t        + 3. Insert Magazine\n");
Console.Write("\n\t\t        + 4. View Magazine\n");
Console.Write("\n\t\t        + 5. Library\n");
Console.Write("\n\t\t        + 6. Exit program\n");
Console.Write("\n\t\t   Please choose options 1 -> 6 : ");
n = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (n == 1)
{
option1:
    books.insert();

    if (!(Console.ReadKey().Key == ConsoleKey.Y))
    {
        Console.Clear();
        goto option1;
    }
    Console.Clear();
    goto back;
}
else if (n == 2)
{
option2:
    books.view();

    if (!(Console.ReadKey().Key == ConsoleKey.Y))
    {
        Console.Clear();
        goto option2;
    }

    Console.Clear();
    goto back;
}
else if (n == 3)
{
option3:
    magazine.insert();

    if (!(Console.ReadKey().Key == ConsoleKey.Y))
    {
        Console.Clear();
        goto option3;
    }

    Console.Clear();
    goto back;
}
else if (n == 4)
{
option4:
    magazine.view();

    if (!(Console.ReadKey().Key == ConsoleKey.Y))
    {
        Console.Clear();
        goto option4;
    }

    Console.Clear();
    goto back;
}
else if (n == 5)
{
    int e;
Menu:
    Console.Clear();
    Console.Write("\t\t-----------------------------------------\n");
    Console.Write("\t\t             Library Menu\n");
    Console.Write("\t\t-----------------------------------------\n");
    Console.Write("\n\t\t      + 1. View Books data\n");
    Console.Write("\n\t\t      + 2. View Magazine data\n");
    Console.Write("\n\t\t      + 3. Back\n");
    Console.Write("\n\t\t   Please choose options 1 -> 3 : ");
    e = Convert.ToInt32(Console.ReadLine());

    if (e == 1)
    {
        int m;
    back1:
        Console.Clear();
        Console.Write("\t\t-----------------------------------------\n");
        Console.Write("\t\t            Book in Library \n");
        Console.Write("\t\t-----------------------------------------\n");
        Console.Write("\n\t\t     + 1. View Books that input\n");
        Console.Write("\n\t\t     + 2. View Books by get, set\n");
        Console.Write("\n\t\t     + 3. Back\n");
        Console.Write("\n\t\t   Please choose options 1 -> 3 : ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (m == 1)
        {
        op1:
            books.view();

            if (!(Console.ReadKey().Key == ConsoleKey.Y))
            {
                Console.Clear();
                goto op1;
            }

            Console.Clear();
            goto back1;
        }
        else if (m == 2)
        {   
            //Console.Clear();
            op2:
            //-------------------
            library.AddBook(b1);
            library.AddBook(b2);
            library.AddBook(b3);
            int totalBook = library.GetTotalBook();
            //-------------------
            Console.Write($"\n\n\t\t\tTotal book in library : { totalBook}  books");
            library.PrintAllBook();
            Console.Write("\nPlease enter 'Y' back to menu and any key to use option 2 again !!!!!");
            //Console.Clear();
            if (!(Console.ReadKey().Key == ConsoleKey.Y))
            {
                Console.Clear();
                goto op2;
            }
            //Console.Clear(); 
            goto back1;
            
        }
        else if (m == 3)
        {
            Console.Clear();
            goto Menu;
        }

    }
    else if (e == 2)
    {
        int l;
        back2:
        Console.Clear();
        Console.Write("\t\t-----------------------------------------\n");
        Console.Write("\t\t           Magazine in Library \n");
        Console.Write("\t\t-----------------------------------------\n");
        Console.Write("\n\t\t     + 1. View Books that input\n");
        Console.Write("\n\t\t     + 2. View Books by get, set\n");
        Console.Write("\n\t\t     + 3. Back\n");
        Console.Write("\n\t\t   Please choose options 1 -> 3 : ");
        l = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (l == 1)
        {
            oma:
            magazine.view();

            if (!(Console.ReadKey().Key == ConsoleKey.Y))
            {
                Console.Clear();
                goto oma;
            }

            Console.Clear();
            goto back2;
        }
        else if (l == 2)
        {
            oma1:

            //-------------------
            library.AddMagazine(l1);
            library.AddMagazine(l2);
            library.AddMagazine(l3);
            int totalMagazine = library.GetTotalMagazine();
            //-------------------
            Console.Write($"\n\n\t\t\tTotal book in library : {totalMagazine}  magazines");

            library.PrintAllMagazine();

            Console.Write("\nPlease enter 'Y' back to menu and any key to use option 2 again !!!!!");
           
            if (!(Console.ReadKey().Key == ConsoleKey.Y))
            {
                Console.Clear();
                goto oma1;
            }

            goto Menu;
        }
        else if (l == 3)
        {
            Console.Clear();
            goto Menu;
        }
    }
    else if (e == 3)
    {
        Console.Clear();
        goto back;
    }
    

}
else if (n == 6)
{
    return;
}
