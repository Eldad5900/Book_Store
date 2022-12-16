using Model.Enames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book : ProductItem
    {
        public string Summery { get; set; }
        public BookGenre BookGener { get; set; }
        public DateTime PrintData { get; set; }
        public Book(string name, string authorNames, int amountOfCopies, double price, string summery, BookGenre bookGener, DateTime printData, int eddition = 1)
            : base(name, authorNames,amountOfCopies,price,eddition)
        {
            PrintData = printData;
            BookGener = bookGener;
            Summery = summery;
        }
    }
}
