using bookstoorprojcet222.Viwes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace bookstoorprojcet222.ViewModel
{
    public class ManigerViweModel: ViewModelBase
    {
        public string MyPassWord { get; set; }
        public RelayCommand PasswordCommand { get; set; } 
        List<string> AllPassword { get; set; }
        public RelayCommand MyBack { get; set; }

        public ManigerViweModel()
        {
            PasswordCommand = new RelayCommand(ShrPassWard);
            MyBack = new RelayCommand(GoBack);
            AllPassword = new List<string>();
            AddPassword();
        }

        private void GoBack()
        {
            MessengerInstance.Send((UserControl)new StartViwe());
        }

        public void ShrPassWard()
        {
            
            bool l = true;
            foreach (var item in AllPassword)
            {
                if(item == MyPassWord)
                {
                    MessengerInstance.Send((UserControl)new MangerMinViwe());
                    l = false;
                    break;
                }
            }
            if(l == true)
            {
                MessageBox.Show("is no a password");
            }


        }
        private void AddPassword()
        {
            AllPassword.Add("0");
            AllPassword.Add("12345");
        }
    }
}
