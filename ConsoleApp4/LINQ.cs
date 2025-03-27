using System.Collections.Generic;
using System.Linq;

namespace LibrarySystem
{
    public static class LinqQueries<T> where T : Media
    {
        public static IEnumerable<T> FilterByYear(IEnumerable<T> items, int year)
        {
            return items.Where(item => item.YearPublished == year).ToList();
        }

        public static IEnumerable<T> GetAllAvailable(IEnumerable<T> items)
        {
            return items.Where(item => item.IsAvailable).ToList();
        }

        public static IEnumerable<T> FindByAuthor(IEnumerable<T> items, string author)
        {
            return items.Where(item => item.Author == author).ToList();
        }

        public static IEnumerable<T> SortByTitle(IEnumerable<T> items)
        {
            return items.OrderBy(item => item.Title).ToList();
        }
    }
}