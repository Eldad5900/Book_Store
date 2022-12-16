using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class ProductItem
    {
        public Guid Id { get; }

        public string Name { get; set; }

        public int AmountOfCopies { get; set; }

        public string AuthorNames { get; set; }
        public DateTime PublishDate { get; set; }
        public double Specials { get; set; }

        public int Eddition { get; set;}
        public double Pric { get; set; }
        public ProductItem(string name,string authorNames, int amountOfCopies, double price , int eddition = 1,int specials=0)
        {
            Id = Guid.NewGuid();
            Name = name;
            AuthorNames = authorNames;
            AmountOfCopies = amountOfCopies;
            Eddition = eddition;
            Pric = price;
            Specials = specials;
        }
    }
}
