using Model.Enames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Journal : ProductItem
    {
        public JournalGenres LstJournalGenres { get; set; }

        public JournalFrquequency Frequency { get; set; }

        public Journal(string name, string authorNames, int amountOfCopies, double price, JournalGenres lstJournalGenres, JournalFrquequency frequency, int eddition = 1)
            : base(name, authorNames, amountOfCopies,price,eddition)
        {
            LstJournalGenres = lstJournalGenres;
            Frequency = frequency;
        }
    }
}
