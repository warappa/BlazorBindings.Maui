// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using ACD = Avalonia.Controls.Documents;
using BlazorBindings.AvaloniaBindings.Elements;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements.Documents
{
    /// <summary>
    /// TextElement is an base class for content in text based controls. TextElements span other content, applying property values or providing structural information.
    /// </summary>
    public abstract partial class TextElement : BlazorBindings.AvaloniaBindings.Elements.StyledElement
    {
        static TextElement()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a brush used to paint the control's background.
        /// </summary>
        [Parameter] public global::Avalonia.Media.IBrush Background { get; set; }
        /// <summary>
        /// Gets or sets the font family.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontFamily FontFamily { get; set; }
        /// <summary>
        /// Gets or sets the font size.
        /// </summary>
        [Parameter] public double? FontSize { get; set; }
        /// <summary>
        /// Gets or sets the font stretch.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontStretch? FontStretch { get; set; }
        /// <summary>
        /// Gets or sets the font style.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontStyle? FontStyle { get; set; }
        /// <summary>
        /// Gets or sets the font weight.
        /// </summary>
        [Parameter] public global::Avalonia.Media.FontWeight? FontWeight { get; set; }
        /// <summary>
        /// Gets or sets a brush used to paint the text.
        /// </summary>
        [Parameter] public global::Avalonia.Media.IBrush Foreground { get; set; }

        public new ACD.TextElement NativeControl => (ACD.TextElement)((AvaloniaObject)this).NativeControl;


        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Background):
                    if (!Equals(Background, value))
                    {
                        Background = (global::Avalonia.Media.IBrush)value;
                        NativeControl.Background = Background;
                    }
                    break;
                case nameof(FontFamily):
                    if (!Equals(FontFamily, value))
                    {
                        FontFamily = (global::Avalonia.Media.FontFamily)value;
                        NativeControl.FontFamily = FontFamily;
                    }
                    break;
                case nameof(FontSize):
                    if (!Equals(FontSize, value))
                    {
                        FontSize = (double?)value;
                        NativeControl.FontSize = FontSize ?? (double)ACD.TextElement.FontSizeProperty.GetDefaultValue(ACD.TextElement.FontSizeProperty.OwnerType);
                    }
                    break;
                case nameof(FontStretch):
                    if (!Equals(FontStretch, value))
                    {
                        FontStretch = (global::Avalonia.Media.FontStretch?)value;
                        NativeControl.FontStretch = FontStretch ?? (global::Avalonia.Media.FontStretch)ACD.TextElement.FontStretchProperty.GetDefaultValue(ACD.TextElement.FontStretchProperty.OwnerType);
                    }
                    break;
                case nameof(FontStyle):
                    if (!Equals(FontStyle, value))
                    {
                        FontStyle = (global::Avalonia.Media.FontStyle?)value;
                        NativeControl.FontStyle = FontStyle ?? (global::Avalonia.Media.FontStyle)ACD.TextElement.FontStyleProperty.GetDefaultValue(ACD.TextElement.FontStyleProperty.OwnerType);
                    }
                    break;
                case nameof(FontWeight):
                    if (!Equals(FontWeight, value))
                    {
                        FontWeight = (global::Avalonia.Media.FontWeight?)value;
                        NativeControl.FontWeight = FontWeight ?? (global::Avalonia.Media.FontWeight)ACD.TextElement.FontWeightProperty.GetDefaultValue(ACD.TextElement.FontWeightProperty.OwnerType);
                    }
                    break;
                case nameof(Foreground):
                    if (!Equals(Foreground, value))
                    {
                        Foreground = (global::Avalonia.Media.IBrush)value;
                        NativeControl.Foreground = Foreground;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        static partial void RegisterAdditionalHandlers();
    }
}
