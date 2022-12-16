using bookstoorprojcet222.Viwes;
using Dill;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace bookstoorprojcet222.ViewModel
{
    public class MangerReportViewModel : ViewModelBase
    {
        public RelayCommand MyBack { get; set; }
        private ObservableCollection<ProductItem> allRemove;

        public ObservableCollection<ProductItem> AllRemove { get => allRemove; set => Set(ref allRemove, value);}
        public MangerReportViewModel()
        {
            Inite(true);
            MessengerInstance.Register<bool>(this, "Tb", Inite);
            MyBack = new RelayCommand(GoBackNew);
        }
        public void Inite(bool tru)
        {
            AllRemove = new ObservableCollection<ProductItem>(DataService.Instance.GetAllRemove());
        }

        private void GoBackNew()
        {
            MessengerInstance.Send((UserControl)new MangerMinuView());
        }
    }
}
