using bookstoorprojcet222.Viwes;
using Dill;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace bookstoorprojcet222.ViewModel
{
    public class MangerSearchAllViweModel : ViewModelBase
    {
        private Journal myJounal;
        private Book myBook;
        private List<Book> allBookStor123;
        private ObservableCollection<Book> allBookStors;
        private ObservableCollection<Journal> allJournalss;
        public int SomeBook { get; set; }
        public int SomeJuornl { get; set; }

        public RelayCommand MyBack { get; set; }
        public List<Book> AllBookStor123 { get => allBookStor123; set => Set(ref allBookStor123, value); }
        public ObservableCollection<Book> AllBookStors { get => allBookStors; set => Set(ref allBookStors, value); }
        public ObservableCollection<Journal> AllJournalss { get => allJournalss; set => Set(ref allJournalss, value); }
        public Book MyBook { get => myBook; set => Set(ref myBook, value); }
        public Journal MyJounal { get => myJounal; set => Set(ref myJounal, value); }
        public RelayCommand DeleteBook { get; set; }
        public RelayCommand DeleteJoural { get; set; }
        public RelayCommand AddSpecialBook { get; set; }
        public RelayCommand AddSpecialJournal { get; set; }
        public double[] Specials { get; set; }
        public double SpecialPrice { get; set; }
        public double SpecialPrices { get; set; }
        public MangerSearchAllViweModel()
        {
            AllBookStor123 = new List<Book>();
            AllBookStors = new ObservableCollection<Book>();
            AllJournalss = new ObservableCollection<Journal>();
            MyBack = new RelayCommand(GoBack);
            AddSpecialBook = new RelayCommand(GoAddSpecialBook);
            AddSpecialJournal = new RelayCommand(GoAddSpecialJounral);
            DeleteBook = new RelayCommand(DeeteItemNew);
            DeleteJoural = new RelayCommand(DeeteJuornalNew);
            MessengerInstance.Register<bool>(this, "All", InStor);
            Specials = new double[9] {10,20,30,40,50,60,70,80,90};
        }

        private void GoAddSpecialBook()
        {
            if (MyBook == null) return;

            MessageBox.Show("the updated is Updete in book");
            SpecialPrices = myBook.Pric/100 * SpecialPrice;
            myBook.Specials = SpecialPrices;
        }
        private void GoAddSpecialJounral()
        {
            if (MyJounal == null) return;

            MessageBox.Show("the Special is updated in juornal");
            SpecialPrices = myJounal.Pric / 100 * SpecialPrice;
            myJounal.Specials = SpecialPrices;
        }

        public void InStor(bool d)
        {
            AllJournalss.Clear();
            AllBookStors.Clear();
            GetAllJuornal();
            GetAll();
        }

        private void DeeteJuornalNew()
        {
            if (SomeJuornl == 0)
            {
                MessageBox.Show("add some juornl you wont remove");
                return;
            }
            if (myJounal.Eddition < SomeJuornl)
            {
                SomeJuornl = 0;
                MessageBox.Show("she wrote down more things to delete than there are");
            }
            else
            {
                myJounal.Eddition -= SomeJuornl;
                MessageBox.Show("the juornel is delete");
            }

            foreach (var item in AllJournalss)
            {
                if (myJounal == null) return;
                if (myJounal.Eddition == 0)
                    if (myJounal.Eddition == 0)
                    {
                        if (item.Id == myJounal.Id)
                        {
                            DataService.Instance.RemoveItem(item);
                            AllJournalss.Remove(item);
                            break;
                        }
                    }
            }
        }

        private void DeeteItemNew()
        {
            if (SomeBook == 0)
            {
                MessageBox.Show("add some book you wont remove");
                return;
            }
            if (myBook.Eddition < SomeBook)
            {
                SomeBook = 0;
                MessageBox.Show("she wrote down more things to delete than there are");
            }
            else
            {
                myBook.Eddition -= SomeBook;
                MessageBox.Show("the book is delete");
            }

            if (myBook.Eddition == 0)
            {
                foreach (var item in AllBookStors)
                {
                    if (MyBook == null) return;
                    if (item.Id == MyBook.Id)
                    {
                        DataService.Instance.RemoveItem(item);
                        AllBookStors.Remove(item);
                        DataService.Instance.Items.Remove(item);
                        break;
                    }
                }
            }
        }

        private void GoBack()
        {
            MessengerInstance.Send((UserControl)new MangerMinuView());
        }
        public void GetAll()
        {
            foreach (var item in DataService.Instance.GetBooks())
            {
                AllBookStors.Add(item);
            }


        }
        public void GetAllJuornal()
        {
            foreach (var item in DataService.Instance.GetJournal())
            {
                AllJournalss.Add(item);
            }
        }
    }
}
