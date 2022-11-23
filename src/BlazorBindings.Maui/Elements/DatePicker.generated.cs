// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class DatePicker : View
    {
        static DatePicker()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public double? CharacterSpacing { get; set; }
        /// <summary>
        /// Gets a value that indicates whether the font for the date picker text is bold, italic, or neither.
        /// </summary>
        [Parameter] public MC.FontAttributes? FontAttributes { get; set; }
        [Parameter] public bool? FontAutoScalingEnabled { get; set; }
        /// <summary>
        /// Gets or sets the font family for the picker text.
        /// </summary>
        [Parameter] public string FontFamily { get; set; }
        /// <summary>
        /// Gets or sets the size of the font for the text in the picker.
        /// </summary>
        /// <value>
        /// A <see langword="double" /> that indicates the size of the font.
        /// </value>
        [Parameter] public double? FontSize { get; set; }
        /// <summary>
        /// The format of the date to display to the user. This is a dependency property.
        /// </summary>
        /// <value>
        /// A valid date format.
        /// </value>
        [Parameter] public string Format { get; set; }
        /// <summary>
        /// Gets or sets the text color for the date picker.
        /// </summary>
        [Parameter] public Color TextColor { get; set; }

        public new MC.DatePicker NativeControl => (MC.DatePicker)((BindableObject)this).NativeControl;

        protected override MC.DatePicker CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(CharacterSpacing):
                    if (!Equals(CharacterSpacing, value))
                    {
                        CharacterSpacing = (double?)value;
                        NativeControl.CharacterSpacing = CharacterSpacing ?? (double)MC.DatePicker.CharacterSpacingProperty.DefaultValue;
                    }
                    break;
                case nameof(FontAttributes):
                    if (!Equals(FontAttributes, value))
                    {
                        FontAttributes = (MC.FontAttributes?)value;
                        NativeControl.FontAttributes = FontAttributes ?? (MC.FontAttributes)MC.DatePicker.FontAttributesProperty.DefaultValue;
                    }
                    break;
                case nameof(FontAutoScalingEnabled):
                    if (!Equals(FontAutoScalingEnabled, value))
                    {
                        FontAutoScalingEnabled = (bool?)value;
                        NativeControl.FontAutoScalingEnabled = FontAutoScalingEnabled ?? (bool)MC.DatePicker.FontAutoScalingEnabledProperty.DefaultValue;
                    }
                    break;
                case nameof(FontFamily):
                    if (!Equals(FontFamily, value))
                    {
                        FontFamily = (string)value;
                        NativeControl.FontFamily = FontFamily;
                    }
                    break;
                case nameof(FontSize):
                    if (!Equals(FontSize, value))
                    {
                        FontSize = (double?)value;
                        NativeControl.FontSize = FontSize ?? (double)MC.DatePicker.FontSizeProperty.DefaultValue;
                    }
                    break;
                case nameof(Format):
                    if (!Equals(Format, value))
                    {
                        Format = (string)value;
                        NativeControl.Format = Format;
                    }
                    break;
                case nameof(TextColor):
                    if (!Equals(TextColor, value))
                    {
                        TextColor = (Color)value;
                        NativeControl.TextColor = TextColor;
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
