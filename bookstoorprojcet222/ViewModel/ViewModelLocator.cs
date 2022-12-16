/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:bookstoorprojcet222"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using bookstoorprojcet222.BuyerViewModel;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;


namespace bookstoorprojcet222.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<BuyerViweModel>();
            SimpleIoc.Default.Register<StartViweModel>();
            SimpleIoc.Default.Register<ManigerViweModel>();
            SimpleIoc.Default.Register<MinuViewModel>();
            SimpleIoc.Default.Register<MangerSearchAllViweModel>();
            SimpleIoc.Default.Register<ManagerAddBookViewModel>();
            SimpleIoc.Default.Register<AddBookViewModel>();
            SimpleIoc.Default.Register<AddBookViewModel>();
            SimpleIoc.Default.Register<BuyBookVIewModel>();
            SimpleIoc.Default.Register<MangerReportViewModel>();


        }

        public MainViewModel Main =>ServiceLocator.Current.GetInstance<MainViewModel>();
        public BuyerViweModel Buyer => ServiceLocator.Current.GetInstance<BuyerViweModel>();
        public StartViweModel Start => ServiceLocator.Current.GetInstance<StartViweModel>();
        public ManigerViweModel Maniger => ServiceLocator.Current.GetInstance<ManigerViweModel>();
        public MinuViewModel MinManiger => ServiceLocator.Current.GetInstance<MinuViewModel>();
        public MangerSearchAllViweModel MinManigerSearchAll => ServiceLocator.Current.GetInstance<MangerSearchAllViweModel>();
        public ManagerAddBookViewModel MinManigerAddBook => ServiceLocator.Current.GetInstance<ManagerAddBookViewModel>();
        public AddBookViewModel AddBook => ServiceLocator.Current.GetInstance<AddBookViewModel>();
        public AddBookViewModel AddJorenal => ServiceLocator.Current.GetInstance<AddBookViewModel>();
        public BuyBookVIewModel BuyBooks => ServiceLocator.Current.GetInstance<BuyBookVIewModel>();
        public MangerReportViewModel Report => ServiceLocator.Current.GetInstance<MangerReportViewModel>();

    }
}