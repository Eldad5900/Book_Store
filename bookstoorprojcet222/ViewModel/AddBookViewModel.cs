using Dill;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Scripting.Runtime;
using Model;
using Model.Enames;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace bookstoorprojcet222.ViewModel
{
    public class AddBookViewModel:ViewModelBase
    {
      
        private Book currentBook;
        private Journal currentJournal;
        private MangerSearchAllViweModel mangerSearchAllViweModel;

        //-----------------------------------------------------
        public string Name { get; set; }
        public string AuthorNames { get; set; }
        public int AmountOfCopies { get; set; }
        public int EddAmount { get; set; }
        public double price { get; set; }
        public string Summery { get; set; }
        public DateTime PrintDate { get; set; }
        public BookGenre[] ItemTypes { get; set; }
        public BookGenre ItemType { get; set; }
        //-----------------------------------------------------
        public JournalGenres JournalGenre { get; set; }
        public JournalGenres[] Genress { get; set; }
        public JournalFrquequency[] journalFrquequencyss { get; set; }
        public JournalFrquequency journalFrquequencys { get; set; }
        //-----------------------------------------------------
        public RelayCommand AddBookCommand { get; set; }
        public RelayCommand AddJournalCommand { get; set; }
        public AddBookViewModel()
        {
            mangerSearchAllViweModel = new MangerSearchAllViweModel();
            AddBookCommand = new RelayCommand(AddBookNew);
            AddJournalCommand = new RelayCommand(AddJournalNew);
            ItemTypes = (BookGenre[])Enum.GetValues(typeof(BookGenre));
            Genress = (JournalGenres[])Enum.GetValues(typeof(JournalGenres));
            journalFrquequencyss = (JournalFrquequency[])Enum.GetValues(typeof(JournalFrquequency));
        }

        private void AddJournalNew()
        {
            if (Name == null || AuthorNames == null) return;
            DataService.Instance.AddItem(currentJournal = new Journal(Name,  AuthorNames, AmountOfCopies, price, JournalGenre , journalFrquequencys,EddAmount));
            MessageBox.Show("Journal is add");
        }

        private void AddBookNew()
        {
            if (Name == null || AuthorNames == null) return;
            DataService.Instance.AddItem(currentBook = new Book(Name, AuthorNames, AmountOfCopies, price, Summery, ItemType
            , PrintDate,EddAmount));
            MessageBox.Show("Book is add");
        }
    
    }
}
