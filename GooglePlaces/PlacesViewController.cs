using Foundation;
using Google.Places;
using UIKit;

namespace GooglePlaces
{
    public class PlacesViewController : UIViewController
    {
        private readonly PlacesClient _placesClient;

        public PlacesViewController(PlacesClient placesClient)
        {
            _placesClient = placesClient;
        }

        public override void LoadView()
        {
            View = new UIView()
            {
                BackgroundColor = UIColor.SystemBackgroundColor
            };
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _placesClient.FindAutocompletePredictions("Collins Street", null,
                AutocompleteBoundsMode.Bias, null, null,
                AutocompletePredictions);
        }

        private void AutocompletePredictions(AutocompletePrediction[] predictions, NSError error)
        {

        }

    }
}
