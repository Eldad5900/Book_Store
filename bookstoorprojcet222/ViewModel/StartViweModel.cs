using bookstoorprojcet222.BuyerView;
using bookstoorprojcet222.Viwes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace bookstoorprojcet222.ViewModel
{
    public class StartViweModel:ViewModelBase
    {
        public RelayCommand ManigerCommand  { get; set; }
        public RelayCommand BuyerCommand { get; set; }
        public StartViweModel()
        {
            ManigerCommand = new RelayCommand(Maniger);
            BuyerCommand = new RelayCommand(BuyerStart);
        }

        private void Maniger()
        {
            MessengerInstance.Send((UserControl)new ManigerViwe());
        }

        private void BuyerStart()
        {
            MessengerInstance.Send<bool>(true,"In");
            MessengerInstance.Send((UserControl) new BuyBookView());
        }

       
    }
}
