using bookstoorprojcet222.Viwes;
using GalaSoft.MvvmLight;
using System.Windows.Controls;

namespace bookstoorprojcet222.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private UserControl myContent;

        public UserControl MyContent { get => myContent; set => Set(ref myContent, value);}
        public MainViewModel()
        {
            MyContent = new StartViwe();
            MessengerInstance.Register<UserControl>(this, UpdatStart);
        }
        private void UpdatStart(UserControl userControl)
        {
            MyContent = userControl;
        }
    }
}