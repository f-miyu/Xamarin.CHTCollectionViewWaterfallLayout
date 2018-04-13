using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Xamarin.CHTCollectionViewWaterfallLayout
{
    [Static]
    partial interface CHTCollectionElementKindSection
    {
        // extern NSString *const CHTCollectionElementKindSectionHeader;
        [Field("CHTCollectionElementKindSectionHeader", "__Internal")]
        NSString Header { get; }

        // extern NSString *const CHTCollectionElementKindSectionFooter;
        [Field("CHTCollectionElementKindSectionFooter", "__Internal")]
        NSString Footer { get; }
    }

    // @protocol CHTCollectionViewDelegateWaterfallLayout <UICollectionViewDelegate>
    [Protocol, Model]
    interface CHTCollectionViewDelegateWaterfallLayout : IUICollectionViewDelegate
    {
        // @required -(CGSize)collectionView:(UICollectionView *)collectionView layout:(UICollectionViewLayout *)collectionViewLayout sizeForItemAtIndexPath:(NSIndexPath *)indexPath;
        [Abstract]
        [Export("collectionView:layout:sizeForItemAtIndexPath:")]
        CGSize GetSizeForItemAtIndexPath(UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, NSIndexPath indexPath);

        // @optional -(NSInteger)collectionView:(UICollectionView *)collectionView layout:(UICollectionViewLayout *)collectionViewLayout columnCountForSection:(NSInteger)section;
        [Export("collectionView:layout:columnCountForSection:")]
        nint GetColumnCountForSection(UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, nint section);

        // @optional -(CGFloat)collectionView:(UICollectionView *)collectionView layout:(UICollectionViewLayout *)collectionViewLayout heightForHeaderInSection:(NSInteger)section;
        [Export("collectionView:layout:heightForHeaderInSection:")]
        nfloat GetHeightForHeaderInSection(UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, nint section);

        // @optional -(CGFloat)collectionView:(UICollectionView *)collectionView layout:(UICollectionViewLayout *)collectionViewLayout heightForFooterInSection:(NSInteger)section;
        [Export("collectionView:layout:heightForFooterInSection:")]
        nfloat GetHeightForFooterInSection(UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, nint section);

        // @optional -(UIEdgeInsets)collectionView:(UICollectionView *)collectionView layout:(UICollectionViewLayout *)collectionViewLayout insetForSectionAtIndex:(NSInteger)section;
        [Export("collectionView:layout:insetForSectionAtIndex:")]
        UIEdgeInsets GetInsetForSectionAtIndex(UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, nint section);

        // @optional -(UIEdgeInsets)collectionView:(UICollectionView *)collectionView layout:(UICollectionViewLayout *)collectionViewLayout insetForHeaderInSection:(NSInteger)section;
        [Export("collectionView:layout:insetForHeaderInSection:")]
        UIEdgeInsets GetInsetForHeaderInSection(UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, nint section);

        // @optional -(UIEdgeInsets)collectionView:(UICollectionView *)collectionView layout:(UICollectionViewLayout *)collectionViewLayout insetForFooterInSection:(NSInteger)section;
        [Export("collectionView:layout:insetForFooterInSection:")]
        UIEdgeInsets GetInsetForFooterInSection(UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, nint section);

        // @optional -(CGFloat)collectionView:(UICollectionView *)collectionView layout:(UICollectionViewLayout *)collectionViewLayout minimumInteritemSpacingForSectionAtIndex:(NSInteger)section;
        [Export("collectionView:layout:minimumInteritemSpacingForSectionAtIndex:")]
        nfloat GetMinimumInteritemSpacingForSectionAtIndex(UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, nint section);

        // @optional -(CGFloat)collectionView:(UICollectionView *)collectionView layout:(UICollectionViewLayout *)collectionViewLayout minimumColumnSpacingForSectionAtIndex:(NSInteger)section;
        [Export("collectionView:layout:minimumColumnSpacingForSectionAtIndex:")]
        nfloat GetMinimumColumnSpacingForSectionAtIndex(UICollectionView collectionView, UICollectionViewLayout collectionViewLayout, nint section);
    }

    // @interface CHTCollectionViewWaterfallLayout : UICollectionViewLayout
    [BaseType(typeof(UICollectionViewLayout))]
    interface CHTCollectionViewWaterfallLayout
    {
        // @property (assign, nonatomic) NSInteger columnCount;
        [Export("columnCount")]
        nint ColumnCount { get; set; }

        // @property (assign, nonatomic) CGFloat minimumColumnSpacing;
        [Export("minimumColumnSpacing")]
        nfloat MinimumColumnSpacing { get; set; }

        // @property (assign, nonatomic) CGFloat minimumInteritemSpacing;
        [Export("minimumInteritemSpacing")]
        nfloat MinimumInteritemSpacing { get; set; }

        // @property (assign, nonatomic) CGFloat headerHeight;
        [Export("headerHeight")]
        nfloat HeaderHeight { get; set; }

        // @property (assign, nonatomic) CGFloat footerHeight;
        [Export("footerHeight")]
        nfloat FooterHeight { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets headerInset;
        [Export("headerInset", ArgumentSemantic.Assign)]
        UIEdgeInsets HeaderInset { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets footerInset;
        [Export("footerInset", ArgumentSemantic.Assign)]
        UIEdgeInsets FooterInset { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets sectionInset;
        [Export("sectionInset", ArgumentSemantic.Assign)]
        UIEdgeInsets SectionInset { get; set; }

        // @property (assign, nonatomic) CHTCollectionViewWaterfallLayoutItemRenderDirection itemRenderDirection;
        [Export("itemRenderDirection", ArgumentSemantic.Assign)]
        CHTCollectionViewWaterfallLayoutItemRenderDirection ItemRenderDirection { get; set; }

        // @property (assign, nonatomic) CGFloat minimumContentHeight;
        [Export("minimumContentHeight")]
        nfloat MinimumContentHeight { get; set; }

        // -(CGFloat)itemWidthInSectionAtIndex:(NSInteger)section;
        [Export("itemWidthInSectionAtIndex:")]
        nfloat ItemWidthInSectionAtIndex(nint section);
    }
}