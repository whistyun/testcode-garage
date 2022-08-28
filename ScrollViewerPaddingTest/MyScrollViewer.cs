using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Layout;
using Avalonia.Markup.Xaml.MarkupExtensions;
using Avalonia.Media;
using Avalonia.Media.TextFormatting;

namespace ScrollViewerPaddingTest
{
    public class MyScrollViewer : ScrollViewer
    {
        protected override Size MeasureOverride(Size availableSize)
        {
            var scale = LayoutHelper.GetLayoutScale(this);

            var padding = LayoutHelper.RoundLayoutThickness(Padding, scale, scale);

            availableSize = availableSize.Deflate(padding);

            return base.MeasureOverride(availableSize).Inflate(padding);
        }
    }
}
