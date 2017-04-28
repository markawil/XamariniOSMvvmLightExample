using System;
using GalaSoft.MvvmLight.Helpers;
using MvvmLightX.iOS.ViewModel;

namespace MvvmLightX.iOS
{
    public partial class SecondViewController : ViewControllerLightBase<SecondViewModel>
    {
        public SecondViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            bindings.Add(this.SetBinding(() => Vm.LabelText,
                                        () => label.Text));
        }
    }
}