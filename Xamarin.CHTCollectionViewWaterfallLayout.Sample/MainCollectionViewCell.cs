using System;

using Foundation;
using UIKit;
using CoreGraphics;

namespace Xamarin.CHTCollectionViewWaterfallLayout.Sample
{
    public partial class MainCollectionViewCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("MainCollectionViewCell");
        public static readonly UINib Nib;

        private static MainCollectionViewCell _self;

        private Item _item;
        public Item Item
        {
            get => _item;
            set
            {
                _item = value;

                TitleLabel.Text = _item.Title;
                DescriptionLabel.Text = _item.Description;
            }
        }

        static MainCollectionViewCell()
        {
            Nib = UINib.FromName("MainCollectionViewCell", NSBundle.MainBundle);
        }

        protected MainCollectionViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public static MainCollectionViewCell Create()
        {
            return (MainCollectionViewCell)Nib.Instantiate(null, null)[0];
        }

        public static CGSize CalculateFittingSize(Item item, CGSize size)
        {
            if (_self == null)
            {
                _self = Create();
            }

            var widthConstraint = _self.ContentView.WidthAnchor.ConstraintEqualTo(size.Width);
            widthConstraint.Active = true;

            _self.Item = item;

            _self.ContentView.LayoutIfNeeded();

            var fittingSize = _self.SystemLayoutSizeFittingSize(size);

            widthConstraint.Active = false;

            return fittingSize;
        }
    }
}
