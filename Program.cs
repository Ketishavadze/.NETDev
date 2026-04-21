
using NetDev;

class Program
{
    static List<Book> books = new List<Book>();
    static List<User> users = new List<User>();
    static Dictionary<string, string> borrowed = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Add new book");
            Console.WriteLine("2. Show all books");
            Console.WriteLine("3. Add new user");
            Console.WriteLine("4. Borrow book");
            Console.WriteLine("5. Return book");
            Console.WriteLine("6. Exit");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    ShowBooks();
                    break;
                case "3":
                    AddUser();
                    break;
                case "4":
                    BorrowBook();
                    break;
                case "5":
                    ReturnBook();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            {
                
            }
        }
    }


    private static void AddBook()
    {
        Console.WriteLine("Enter book name");
        string title = Console.ReadLine();
        Console.WriteLine("Enter author");
        string author = Console.ReadLine();
        Console.WriteLine("Enter year");
        int year = int.Parse(Console.ReadLine());
        Book newBook = new Book(title, author, year);
        
        books.Add(newBook);
        Console.WriteLine("Book added");
        
    }

    private static void AddUser()
    {
        Console.WriteLine("Enter user name");
        string name = Console.ReadLine();

        User newUser = new User(name);
        users.Add(newUser);
        Console.WriteLine("User added");
        

    }

    private static void BorrowBook()
    {
        Console.WriteLine("Enter book name");
        string title = Console.ReadLine();
        Console.WriteLine("Enter user name");
        string user = Console.ReadLine();
        
        Book foundBook = null;

        foreach (Book book in books)
        {
            if (book.title == title)
            {
                foundBook = book;
                break;
            }
        }
        if (foundBook == null)
        {
            Console.WriteLine("Book not found");
            return;
        }
        if (borrowed.ContainsKey(title))
        {
            Console.WriteLine("Book already borrowed");
        }
        else
            {
            borrowed.Add(title, user);
            foundBook.isBorrowed = true;
            Console.WriteLine("Book borrowed");

            }
        
        
    }

    private static void ReturnBook()
    {
        Console.WriteLine("Enter book name");
        string title = Console.ReadLine();
        Book foundBook = null;
        foreach (Book book in books)
        {
            if (book.title == title)
            {
                foundBook = book;
                break;
            }
        }

        if (foundBook == null)
        {
            Console.WriteLine("Book not found");
            return;
        }

        if (!foundBook.isBorrowed)
        {
            Console.WriteLine("This book is not borrowed");
            return;
        }
        foundBook.isBorrowed = false;
        borrowed.Remove(title);
        Console.WriteLine("Book returned");
    }

    private static void ShowBooks()
    {
        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
        
    }


}