using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace LibrarySystem
{
    class MusicAlbum : Media
    {
        public string Artist { get; set; }
        public int Tracks { get; set; }

        public MusicAlbum(string title, string artist, int year, int tracks) : base(title, artist, year)
        {
            Artist = artist;
            Tracks = tracks;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Исполнитель: {Artist}, Треки: {Tracks}");
        }
    }
}