using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace LibrarySystem
{
    class Media
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
        public bool IsAvailable { get; set; }

        public Media(string title, string author, int year)
        {
            Title = title;
            Author = author;
            YearPublished = year;
            IsAvailable = true;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Название: {Title}, Автор: {Author}, Год: {YearPublished}, Доступно: {IsAvailable}");
        }
    }
}