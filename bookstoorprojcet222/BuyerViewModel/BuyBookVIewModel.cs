using bookstoorprojcet222.Viwes;
using Dill;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace bookstoorprojcet222.BuyerViewModel
{
    public class BuyBookVIewModel : ViewModelBase
    {
        double AllPrice { get; set; }
        private Journal myJounal;
        private Book myBook;
        public int SomeBook { get; set; }
        public int SomeJuornal { get; set; }
        public Book MyBook { get => myBook; set => Set(ref myBook, value); }
        public Journal MyJounal { get => myJounal; set => Set(ref myJounal, value); }
        private ObservableCollection<Book> allBookStors;
        private ObservableCollection<Journal> allJournalss;
        private ObservableCollection<ProductItem> allShoppingCat;
        public List<ProductItem> ListAll { get; set; }
        public ObservableCollection<Book> AllBookStors { get => allBookStors; set => Set(ref allBookStors, value); }
        public ObservableCollection<Journal> AllJournalss { get => allJournalss; set => Set(ref allJournalss, value); }
        public ObservableCollection<ProductItem> AllShoppingCat { get => allShoppingCat; set => Set(ref allShoppingCat, value); }
        public RelayCommand BuyTheBook { get; set; }
        public RelayCommand AddJournalToShoppingCat { get; set; }
        public RelayCommand BuyAllShoppingCat { get; set; }
        public RelayCommand MyBack { get; set; }
        public BuyBookVIewModel()
        {
            AllPrice = 0;
            AllShoppingCat = new ObservableCollection<ProductItem>();
            BuyAllShoppingCat = new RelayCommand(BuyTheShoppingCatNew);
            AddJournalToShoppingCat = new RelayCommand(AddJournalNew);
            BuyTheBook = new RelayCommand(AddBookNew);
            MyBack = new RelayCommand(BackNew);
            ListAll = new List<ProductItem>();
            MessengerInstance.Register<bool>(this, "In", Inite);
            Inite(true);
        }

        private void Inite(bool obj)
        {
            AllBookStors = new ObservableCollection<Book>(DataService.Instance.GetBooks());
            AllJournalss = new ObservableCollection<Journal>(DataService.Instance.GetJournal());
        }

        private void BackNew()
        {
            MessengerInstance.Send((UserControl)new StartViwe());
        }

        private void AddBookNew()
        {

            if (SomeBook == 0)
            {
                MessageBox.Show("add some book you wont buying");
                return;
            }
            for (int i = 0; i < SomeBook; i++)
            {
                AllShoppingCat.Add(MyBook);
                if (MyBook.Eddition == 0)
                {
                    break;
                }
                if (MyBook.Specials != 0 && i == 0) MyBook.Pric -= MyBook.Specials;
                AllPrice += MyBook.Pric;
                MyBook.Eddition -= 1;
            }
            if (MyBook.Eddition == 0)
            {
                DataService.Instance.RemoveItem(MyBook);
                allBookStors.Remove(MyBook);
            }
        }

        private void AddJournalNew()
        {
            if (SomeJuornal == 0)
            {
                MessageBox.Show("add some juornal you wont to buying");
                return;
            }
            for (int i = 0; i < SomeJuornal; i++)
            {
                AllShoppingCat.Add(MyJounal);
                if (myJounal.Eddition == 0|| myJounal.Eddition == null)
                {
                    break;
                }
                if (myJounal.Specials != 0 && i == 0) MyJounal.Pric -= MyJounal.Specials;
                myJounal.Eddition -= 1;
                AllPrice += myJounal.Pric;
            }
            if (myJounal.Eddition == 0)
            {
                DataService.Instance.RemoveItem(MyJounal);
                AllJournalss.Remove(MyJounal);
            }
        }

        private void BuyTheShoppingCatNew()
        {
            MessageBox.Show($"you buy {allShoppingCat.Count} itmes , is costs -  $ {AllPrice}");
            ListAll = AllShoppingCat.ToList();
            foreach (var item in ListAll)
            {
                DataService.Instance.AllRemove.Add(item);
                allShoppingCat.Remove(item);
            }
        }
    }
}
