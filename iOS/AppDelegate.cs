using Foundation;
using UIKit;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Ioc;

namespace MvvmLightX.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // MVVM Light's DispatcherHelper for cross-thread handling.
            DispatcherHelper.Initialize(application);

            // first step is you need to initiate the NavigationService (again they take over all navigation for you)
            var navService = new NavigationService();
            SimpleIoc.Default.Register<INavigationService>(() => navService);

            // initialize the first NavController as the root
            navService.Initialize((UINavigationController)Window.RootViewController);
            // move the registering of ViewControllers into a new class.
            // if and only if you want to use their NavService for ViewModel to ViewModel navigation
            var secondControllerName = nameof(SecondViewController);
            navService.Configure(secondControllerName, secondControllerName);

            return true;
        }
    }
}

