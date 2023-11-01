using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Knihovna
{
    

    class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; }

        public Book(Author author, string title, int pages, double price)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Price = price;
            Available = true;
        }

        public override string ToString()
        {
            return $"Kniha od {Author.FirstName} {Author.LastName} - {Title}";
        }
    }

    class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> Books { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Author(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Books = new List<Book>();
            DateOfBirth = dateOfBirth;
        }

        public void ListBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public override string ToString()
        {
            return $"Author {FirstName} {LastName}";
        }
    }

    class Reader
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> MyBooks { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Reader(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            MyBooks = new List<Book>();
            DateOfBirth = dateOfBirth;
        }

        public void BorrowBook(Book book)
        {
            if (book.Available)
            {
                book.Available = false;
                MyBooks.Add(book);
            }
        }

        public void ReturnBook(Book book)
        {
            if (!book.Available)
            {
                book.Available = true;
                MyBooks.Remove(book);
            }
        }

        public void ListBorrowed()
        {
            Console.WriteLine("Kniha od " + FirstName + " " + LastName + ":");
            foreach (var book in MyBooks)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }

    class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void ListAvailable()
        {
            Console.WriteLine("Dostupné knihy:");
            foreach (var book in Books)
            {
                if (book.Available)
                {
                    Console.WriteLine(book.ToString());
                }
            }
        }

        public void ListUnavailable()
        {
            Console.WriteLine("Nedostupné knihy:");
            foreach (var book in Books)
            {
                if (!book.Available)
                {
                    Console.WriteLine(book.ToString());
                }
            }
        }

        public void ListAll()
        {
            Console.WriteLine("Všechny knihy:");
            foreach (var book in Books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }

    class TestLibrary
    {
        public static void Mainx(string[] args)
        {
            Author author1 = new Author("Karel", "Jaromir Erben", new DateTime(1811, 11, 7));
            Author author2 = new Author("J.K.", "Rowling", new DateTime(1965, 7, 31));

            Book book1 = new Book(author1, "Kytice", 100, 15.99);
            Book book2 = new Book(author2, "Harry Potter", 320, 19.99);

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);

            Reader reader1 = new Reader("Jan", "Kolek", new DateTime(1980, 1, 15));
            Reader reader2 = new Reader("Alena", "Kal", new DateTime(1995, 5, 3));

            reader1.BorrowBook(book1);
            reader2.BorrowBook(book2);

            reader1.ListBorrowed();
            reader2.ListBorrowed();

            library.ListAvailable();
            library.ListUnavailable();
            library.ListAll();
        }
    }

}
