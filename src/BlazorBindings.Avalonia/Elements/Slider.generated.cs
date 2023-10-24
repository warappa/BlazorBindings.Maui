// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>



#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    /// <summary>
    /// A control that lets the user select from a range of values by moving a Thumb control along a Track.
    /// </summary>
    public partial class Slider : BlazorBindings.AvaloniaBindings.Elements.Primitives.RangeBase
    {
        static Slider()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the direction of increasing value.
        /// </summary>
        /// <value>
        /// true if the direction of increasing value is to the left for a horizontal slider or down for a vertical slider; otherwise, false. The default is false.
        /// </value>
        [Parameter] public bool? IsDirectionReversed { get; set; }
        /// <summary>
        /// Gets or sets a value that indicates whether the <see cref="T:Avalonia.Controls.Slider" /> automatically moves the <see cref="T:Avalonia.Controls.Primitives.Thumb" /> to the closest tick mark.
        /// </summary>
        [Parameter] public bool? IsSnapToTickEnabled { get; set; }
        /// <summary>
        /// Gets or sets the orientation of a <see cref="T:Avalonia.Controls.Slider" />.
        /// </summary>
        [Parameter] public global::Avalonia.Layout.Orientation? Orientation { get; set; }
        /// <summary>
        /// Gets or sets the interval between tick marks.
        /// </summary>
        [Parameter] public double? TickFrequency { get; set; }
        /// <summary>
        /// Gets or sets a value that indicates where to draw tick marks in relation to the track.
        /// </summary>
        [Parameter] public AC.TickPlacement? TickPlacement { get; set; }
        /// <summary>
        /// Defines the ticks to be drawn on the tick bar.
        /// </summary>
        [Parameter] public global::Avalonia.Collections.AvaloniaList<double> Ticks { get; set; }

        public new AC.Slider NativeControl => (AC.Slider)((AvaloniaObject)this).NativeControl;

        protected override AC.Slider CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(IsDirectionReversed):
                    if (!Equals(IsDirectionReversed, value))
                    {
                        IsDirectionReversed = (bool?)value;
                        NativeControl.IsDirectionReversed = IsDirectionReversed ?? (bool)AC.Slider.IsDirectionReversedProperty.GetDefaultValue(AC.Slider.IsDirectionReversedProperty.OwnerType);
                    }
                    break;
                case nameof(IsSnapToTickEnabled):
                    if (!Equals(IsSnapToTickEnabled, value))
                    {
                        IsSnapToTickEnabled = (bool?)value;
                        NativeControl.IsSnapToTickEnabled = IsSnapToTickEnabled ?? (bool)AC.Slider.IsSnapToTickEnabledProperty.GetDefaultValue(AC.Slider.IsSnapToTickEnabledProperty.OwnerType);
                    }
                    break;
                case nameof(Orientation):
                    if (!Equals(Orientation, value))
                    {
                        Orientation = (global::Avalonia.Layout.Orientation?)value;
                        NativeControl.Orientation = Orientation ?? (global::Avalonia.Layout.Orientation)AC.Slider.OrientationProperty.GetDefaultValue(AC.Slider.OrientationProperty.OwnerType);
                    }
                    break;
                case nameof(TickFrequency):
                    if (!Equals(TickFrequency, value))
                    {
                        TickFrequency = (double?)value;
                        NativeControl.TickFrequency = TickFrequency ?? (double)AC.Slider.TickFrequencyProperty.GetDefaultValue(AC.Slider.TickFrequencyProperty.OwnerType);
                    }
                    break;
                case nameof(TickPlacement):
                    if (!Equals(TickPlacement, value))
                    {
                        TickPlacement = (AC.TickPlacement?)value;
                        NativeControl.TickPlacement = TickPlacement ?? (AC.TickPlacement)AC.Slider.TickPlacementProperty.GetDefaultValue(AC.Slider.TickPlacementProperty.OwnerType);
                    }
                    break;
                case nameof(Ticks):
                    if (!Equals(Ticks, value))
                    {
                        Ticks = (global::Avalonia.Collections.AvaloniaList<double>)value;
                        NativeControl.Ticks = Ticks;
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
