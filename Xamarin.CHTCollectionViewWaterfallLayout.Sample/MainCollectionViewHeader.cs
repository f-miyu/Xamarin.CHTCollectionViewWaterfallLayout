using System;

using Foundation;
using UIKit;

namespace Xamarin.CHTCollectionViewWaterfallLayout.Sample
{
    public partial class MainCollectionViewHeader : UICollectionReusableView
    {
        public static readonly NSString Key = new NSString("MainCollectionViewHeader");
        public static readonly UINib Nib;

        static MainCollectionViewHeader()
        {
            Nib = UINib.FromName("MainCollectionViewHeader", NSBundle.MainBundle);
        }

        protected MainCollectionViewHeader(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
