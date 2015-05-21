using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CustomTransitionExample;
using CustomTransitionExample.iOS;

[assembly: ExportRenderer(typeof(CardPage), typeof(CardPageRenderer))]

namespace CustomTransitionExample.iOS
{
    public class CardPageRenderer : PageRenderer
    {
        public override void DidMoveToParentViewController (UIViewController parent)
        {
            base.DidMoveToParentViewController (parent);

            if (ParentViewController != null)
            {
                ParentViewController.ModalPresentationStyle = UIModalPresentationStyle.OverCurrentContext;
            }
        }

        public override void ViewWillAppear (bool animated)
        {
            base.ViewWillAppear (animated);

            View.Superview.BackgroundColor = UIColor.Clear;
        }
    }
}

