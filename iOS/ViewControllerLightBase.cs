using System;
using UIKit;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight;

namespace MvvmLightX.iOS
{
    public class ViewControllerLightBase<T> : UIViewController where T : ViewModelBase
    {
        public ViewControllerLightBase(IntPtr handle) : base(handle)
        {
        }

        // Keep track of bindings to avoid premature garbage collection
        protected readonly List<Binding> bindings = new List<Binding>();

        protected T Vm
        {
            get
            {
                return Application.Locator.ViewModel<T>();
            }
        }
    }
}