using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace MvvmLightX.iOS.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    /// 
    /// 
    /// For simplicity sake I kept the ViewModels inside the iOS class, for real projects you'd
    /// put these in the PCL or Shared Library so they can be shared by iOS and Android
    public class MainViewModel : ViewModelBase
    {
        private readonly INavigationService _navService;
        public MainViewModel(INavigationService navService)
        {
            this._navService = navService;
            _welcomeTite = "Hello World";
        }

        private string _welcomeTite;
        public string WelcomeTitle 
        {
            get { return _welcomeTite; }
            set 
            {
                _welcomeTite = value;
                RaisePropertyChanged(() => WelcomeTitle);
            }
        }

        private RelayCommand navigateCommand;
        public RelayCommand NavigateCommand
        {
            get
            {
                return navigateCommand
                    ?? (navigateCommand = new RelayCommand(() => _navService.NavigateTo("SecondViewController")));
            }
        }
    }
}