using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace LibrarySystem
{
    class Book : Media
    {
        public int Pages { get; set; }
        public string Genre { get; set; }

        public Book(string title, string author, int year, int pages, string genre) : base(title, author, year)
        {
            Pages = pages;
            Genre = genre;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Страницы: {Pages}, Жанр: {Genre}");
        }
    }
}