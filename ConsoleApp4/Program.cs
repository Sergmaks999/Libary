using System;
using System.Collections.Generic;
using System.Linq;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library<Book> bookLibrary = new Library<Book>();
            Library<Movie> movieLibrary = new Library<Movie>();
            Library<MusicAlbum> musicLibrary = new Library<MusicAlbum>();

            bookLibrary.Add(new Book("Война и мир", "Толстой", 1869, 1225, "Роман"));
            bookLibrary.Add(new Book("Преступление и наказание", "Достоевский", 1866, 600, "Драма"));

            bookLibrary.Add(new Book("Война и мир", "Толстой", 1869, 1225, "Роман"));

            movieLibrary.Add(new Movie("Real Stell", "Шен Леви", 2011, 2.7f));
            musicLibrary.Add(new MusicAlbum("Exit", "экспайн", 2021, 10));

            Console.WriteLine("Все книги:");
            bookLibrary.PrintAll();

            Console.WriteLine("\nВсе фильмы:");
            movieLibrary.PrintAll();

            Console.WriteLine("\nВсе альбомы:");
            musicLibrary.PrintAll();

            Console.WriteLine("\nКниги 1866 года:");
            foreach (var book in bookLibrary.FilterByYear(1866))
            {
                book.PrintInfo();
            }

            bookLibrary.Give("Преступление и наказание");
            Console.WriteLine("\nВсе доступные книги:");
            foreach (var book in bookLibrary.GetAllAvailable())
            {
                book.PrintInfo();
            }

            Console.WriteLine("\nКниги Толстого:");
            foreach (var book in bookLibrary.FindByAuthor("Толстой"))
            {
                book.PrintInfo();
            }

            Console.WriteLine("\nКниги, отсортированные по названию:");
            foreach (var book in bookLibrary.SortByTitle())
            {
                book.PrintInfo();
            }

            if (bookLibrary.Remove("Война и мир"))
            {
                Console.WriteLine("\nКнига 'Война и мир' удалена.");
            }
            else
            {
                Console.WriteLine("\nНе удалось удалить книгу 'Война и мир'.");
            }
        }
    }
}