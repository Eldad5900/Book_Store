
using bookstoorprojcet222.Viwes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Web.UI.MobileControls;
using System.Windows.Controls;

namespace bookstoorprojcet222.ViewModel
{
    public class ManagerAddBookViewModel : ViewModelBase
    {
        public RelayCommand MyAddBook { get; set; }
        public RelayCommand MyAddJornal { get; set; }
        public RelayCommand MyBack { get; set; }
        public ManagerAddBookViewModel()
        {
            MyAddBook =new RelayCommand(AddBook);
            MyAddJornal = new RelayCommand(AddJornal);
            MyBack = new RelayCommand(GoBack);
        }

        private void GoBack()
        {
            MessengerInstance.Send((UserControl)new MangerMinuView());
        }

        private void AddBook()
        {
            MessengerInstance.Send((UserControl)new AddBookView());
        }
        private void AddJornal()
        {
            MessengerInstance.Send((UserControl)new AddJounalView());
        }
    }
}
