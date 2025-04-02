using System;
using System.Collections.Generic;
using System.Linq;

namespace LibrarySystem
{
    class Library<T> : IMediaManager<T> where T : Media
    {
        private List<T> items = new List<T>();
        private Dictionary<string, T> itemLookup = new Dictionary<string, T>();

        public void Add(T item)
        {
            try
            {
                if (itemLookup.ContainsKey(item.Title))
                {
                    throw new ArgumentException($"Медиа с названием '{item.Title}' уже существует.");
                }

                items.Add(item);
                itemLookup.Add(item.Title, item);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка при добавлении: {ex.Message}");
            }
        }

        public bool Remove(string title)
        {
            try
            {
                if (!itemLookup.ContainsKey(title))
                {
                    throw new KeyNotFoundException($"Медиа с названием '{title}' не найдено.");
                }

                T itemToRemove = itemLookup[title];
                items.Remove(itemToRemove);
                itemLookup.Remove(title);
                return true;
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Ошибка при удалении: {ex.Message}");
                return false;
            }
        }

        public T FindByTitle(string title)
        {
            try
            {
                if (!itemLookup.ContainsKey(title))
                {
                    throw new KeyNotFoundException($"Медиа с названием '{title}' не найдено.");
                }
                return itemLookup[title];
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Ошибка при поиске: {ex.Message}");
                return default(T);
            }
        }

        public IEnumerable<T> FilterByYear(int year)
        {
            return LinqQueries<T>.FilterByYear(items, year);
        }

        public IEnumerable<T> GetAllAvailable()
        {
            return LinqQueries<T>.GetAllAvailable(items);
        }

        public void Give(string title)
        {
            try
            {
                if (!itemLookup.ContainsKey(title))
                {
                    throw new KeyNotFoundException($"Медиа с названием '{title}' не найдено.");
                }

                itemLookup[title].IsAvailable = false;
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Ошибка при выдаче: {ex.Message}");
            }
        }

        public void Return(string title)
        {
            try
            {
                if (!itemLookup.ContainsKey(title))
                {
                    throw new KeyNotFoundException($"Медиа с названием '{title}' не найдено.");
                }
                itemLookup[title].IsAvailable = true;
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine($"Ошибка при возврате: {ex.Message}");
            }
        }

        public void PrintAll()
        {
            foreach (var item in items)
            {
                item.PrintInfo();
            }
        }

        public IEnumerable<T> FindByAuthor(string author)
        {
            return LinqQueries<T>.FindByAuthor(items, author);
        }

        public IEnumerable<T> SortByTitle()
        {
            return LinqQueries<T>.SortByTitle(items);
        }
    }
}
