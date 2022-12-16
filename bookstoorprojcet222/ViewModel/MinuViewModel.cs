

using bookstoorprojcet222.Viwes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Controls;

namespace bookstoorprojcet222.ViewModel
{
    public class MinuViewModel: ViewModelBase
    {
        public RelayCommand MySerchAll { get; set; }
        public RelayCommand MyAddBook { get; set; }
        public RelayCommand MyBack { get; set; }
        public RelayCommand MyReport { get; set; }
        public MinuViewModel()
        {
            MySerchAll = new RelayCommand(SearchAll);
            MyAddBook = new RelayCommand(AddToBook);
            MyBack = new RelayCommand(GoBackNew);
            MyReport = new RelayCommand(GoMyReport);
        }

        private void GoMyReport()
        {
            MessengerInstance.Send((UserControl) new MangerReportView());
            MessengerInstance.Send<bool>(true, "Tb");
        }

        private void GoBackNew()
        {
            MessengerInstance.Send((UserControl)new StartViwe());
        }

        private void AddToBook()
        {
           
            MessengerInstance.Send((UserControl)new ManagerAddBookView());
            MessengerInstance.Unregister((UserControl)new MangerSearchAllViwe());
        }

        private void SearchAll()
        {
             
            MessengerInstance.Send((UserControl)new MangerSearchAllViwe());
            MessengerInstance.Send(true, "All");
        }
    }
}