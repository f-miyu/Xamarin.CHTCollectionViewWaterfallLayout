using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Xamarin.CHTCollectionViewWaterfallLayout.Sample
{
    public static class ItemsFactory
    {
        public static Item[] Create()
        {
            var rand = new Random();
            return Enumerable.Range(0, 100)
                             .Select(i => new Item($"Title{i}", string.Join(" ", Enumerable.Repeat($"Description{i}", rand.Next(1, 10)))))
                             .ToArray();
        }
    }
}
