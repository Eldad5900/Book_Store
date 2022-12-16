using bookstoorprojcet222.BuyerViewModel;
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
using System.Windows.Controls;

namespace bookstoorprojcet222.ViewModel
{
    public class BuyerViweModel :ViewModelBase
    {
        public BuyBookVIewModel BuyBookVIewModel { get; set;}
        public DataService Product { get; set; }
        private ObservableCollection<ProductItem> observable;
        public ObservableCollection<ProductItem> Observable { get => observable; set =>Set (ref observable , value); }
        public RelayCommand MyBack { get; set; }

        public BuyerViweModel() 
        {
            Product = new DataService();
            BuyBookVIewModel = new BuyBookVIewModel();
            Observable = new ObservableCollection<ProductItem>(BuyBookVIewModel.AllShoppingCat);
            MyBack = new RelayCommand(GoMyBackNew);
        }

        private void GoMyBackNew()
        {
            foreach (var item in observable)
            {
                Observable.Remove(item);
                Product.RemoveItem(item);
            }
            MessengerInstance.Send((UserControl)new StartViwe());
        }
    }
}
