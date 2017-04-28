using Foundation;
using System;
using GalaSoft.MvvmLight.Helpers;

namespace MvvmLightX.iOS
{
    // no need to use a MVLight controller base, awesome
    public partial class MainViewController : ViewControllerLightBase<ViewModel.MainViewModel>
    {
        public MainViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            bindings.Add(this.SetBinding(() => Vm.WelcomeTitle,
                                         () => label.Text));
            bindings.Add(this.SetBinding(() => Vm.WelcomeTitle,
                                         () => textField.Text, BindingMode.TwoWay));
            

            // you can use their Navigation Service if you like, but you'll lose
            // control like in Cross in doing custom transitions that are rather simple in 
            // the native toolsets.  Luckily this is totally optional in MvvmLight, not so
            // in Cross.
            //btn_NavigateToSecondPage.SetCommand("TouchUpInside", Vm.NavigateCommand);
        }
    }
}