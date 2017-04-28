using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace MvvmLightX.iOS.ViewModel
{
    public class SecondViewModel : ViewModelBase 
    {
        private readonly INavigationService _navService;
        public SecondViewModel(INavigationService navService)
        {
            this._navService = navService;
            _labelText = "Hello World on Page 2!";
        }
            
        private string _labelText;
        public string LabelText
        {
            get { return _labelText; }
            set
            {
                _labelText = value;
                RaisePropertyChanged(() => LabelText);
            }
        }
    }
}
