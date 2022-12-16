using Model;
using Model.Enames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dill
{
    public class DataService
    {
        private static DataService instance;
        private List<ProductItem> allRemove;

        public static DataService Instance
        {
            get
            {
                if (instance == null) instance = new DataService();
                return instance;
            }
        }
        public List<ProductItem> Items { get; set; }
        public List<ProductItem> AllRemove
        {
            get
            {
                if (allRemove == null) allRemove = new List<ProductItem>();
                return allRemove;
            }
            set => allRemove = value;
        }
        public static List<Book> LisBooks { get; set; }
        public static List<Journal> Lisjounals { get; set; }
        public DataService()
        {
            Items = new List<ProductItem>
            {
                new Book("Rich Dad Poor Dad","Robert",2,23,"asdff", BookGenre.Action ,DateTime.Now,3),
                new Journal("Not Rationl And Not By Chance","Dan",2,29,JournalGenres.Music,JournalFrquequency.Daily,3),
                 new Book("All WWE","hello",2,23,"asdff", BookGenre.Action ,DateTime.Now,2),
                  new Journal("hello hello","Dan",2,29,JournalGenres.Fashion,JournalFrquequency.Daily,4),
                    new Book("Sosomy","dod",2,23,"sdsd", BookGenre.Action ,DateTime.Now),
                    new Book("Bobiew","dobi",2,23,"sdsd", BookGenre.Action ,DateTime.Now,4),
            };
            LisBooks = Items.OfType<Book>().ToList();
            Lisjounals = Items.OfType<Journal>().ToList();
        }
        public void AddItem(ProductItem item)
        {
            Items.Add(item);
            if (item is Book book)
                LisBooks.Add(book);
            if (item is Journal journal)
                Lisjounals.Add(journal);
        }
        public void RemoveItem(ProductItem item)
        {
            Items.Remove(item);
            if (item is Book book)
                LisBooks.Remove(book);
            if (item is Journal journal)
                Lisjounals.Remove(journal);
        }
        public List<Book> GetBooks()
        {
            return LisBooks;
        }
        public List<Journal> GetJournal()
        {
            return Lisjounals;
        }
        public List<ProductItem> GetAllRemove()
        {
            return AllRemove;
        }
    }
}
