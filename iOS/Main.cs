using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using MvvmLightX.iOS.ViewModel;
using UIKit;

namespace MvvmLightX.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }

        static ViewModelLocator locator;
        public static ViewModelLocator Locator
        {
            get {
                return locator ?? (locator = new ViewModelLocator());
            }
        }
    }
}
