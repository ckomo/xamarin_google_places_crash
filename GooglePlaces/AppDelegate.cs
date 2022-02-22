using Foundation;
using Google.Places;
using UIKit;

namespace GooglePlaces
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIResponder, IUIApplicationDelegate
    {
        public static string GOOGLE_API_KEY = "please_provide_key";

        [Export("window")]
        public UIWindow Window { get; set; }

        [Export("application:didFinishLaunchingWithOptions:")]
        public bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method

            PlacesClient.ProvideApiKey(GOOGLE_API_KEY);

            Window = new UIWindow()
            {
                RootViewController = new PlacesViewController(PlacesClient.SharedInstance)
            };
            Window.MakeKeyAndVisible();

            return true;
        }
    }
}

