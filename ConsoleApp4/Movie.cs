using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace LibrarySystem
{
    class Movie : Media
    {
        public float Duration { get; set; }
        public string Director { get; set; }

        public Movie(string title, string director, int year, float duration) : base(title, director, year)
        {
            Duration = duration;
            Director = director;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Длительность: {Duration}, Режиссер: {Director}");
        }
    }
}