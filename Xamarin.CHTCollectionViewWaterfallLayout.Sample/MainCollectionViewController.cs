using CoreGraphics;
using Foundation;
using System;
using UIKit;

namespace Xamarin.CHTCollectionViewWaterfallLayout.Sample
{
    public partial class MainCollectionViewController : UICollectionViewController, ICHTCollectionViewDelegateWaterfallLayout
    {
        private Item[] _items;

        public MainCollectionViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CollectionView.RegisterNibForCell(MainCollectionViewCell.Nib, MainCollectionViewCell.Key);
            CollectionView.RegisterNibForSupplementaryView(MainCollectionViewHeader.Nib, CHTCollectionElementKindSection.Header, MainCollectionViewHeader.Key);

            if (CollectionView.CollectionViewLayout is CHTCollectionViewWaterfallLayout layout)
            {
                layout.ColumnCount = 3;
                layout.MinimumColumnSpacing = 4;
                layout.MinimumInteritemSpacing = 4;
                layout.ItemRenderDirection = CHTCollectionViewWaterfallLayoutItemRenderDirection.ShortestFirst;
                layout.HeaderHeight = 50;
                layout.HeaderInset = new UIEdgeInsets(0, 0, 4, 0);
            }

            _items = ItemsFactory.Create();
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return _items.Length;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = (MainCollectionViewCell)collectionView.DequeueReusableCell(MainCollectionViewCell.Key, indexPath);

            cell.Item = _items[indexPath.Row];

            return cell;
        }

		public override UICollectionReusableView GetViewForSupplementaryElement(UICollectionView collectionView, NSString elementKind, NSIndexPath indexPath)
		{
            return collectionView.DequeueReusableSupplementaryView(elementKind, MainCollectionViewHeader.Key, indexPath);
		}

		public CGSize GetSizeForItemAtIndexPath(UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, NSIndexPath indexPath)
        {
            nfloat width = 0;
            if (collectionViewLayout is CHTCollectionViewWaterfallLayout layout)
            {
                width = layout.ItemWidthInSectionAtIndex(indexPath.Section);
            }

            var item = _items[indexPath.Row];

            var height = MainCollectionViewCell.CalculateFittingSize(item, new CGSize(width, 0)).Height;

            // 計算誤差で小さくなってしまうことへの対応
            var diff = height - (height * width) / width;
            if (diff > 0)
            {
                height = height + diff;
            }

            return new CGSize(width, height);
        }
    }
}