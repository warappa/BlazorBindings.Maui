// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using AM = Avalonia.Media;
using BlazorBindings.AvaloniaBindings.Elements;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements.Media
{
    /// <summary>
    /// A brush that draws with a linear gradient.
    /// </summary>
    public partial class LinearGradientBrush : GradientBrush
    {
        static LinearGradientBrush()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the end point for the gradient.
        /// </summary>
        [Parameter] public global::Avalonia.RelativePoint? EndPoint { get; set; }
        /// <summary>
        /// Gets or sets the start point for the gradient.
        /// </summary>
        [Parameter] public global::Avalonia.RelativePoint? StartPoint { get; set; }

        public new AM.LinearGradientBrush NativeControl => (AM.LinearGradientBrush)((AvaloniaObject)this).NativeControl;

        protected override AM.LinearGradientBrush CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(EndPoint):
                    if (!Equals(EndPoint, value))
                    {
                        EndPoint = (global::Avalonia.RelativePoint?)value;
                        NativeControl.EndPoint = EndPoint ?? (global::Avalonia.RelativePoint)AM.LinearGradientBrush.EndPointProperty.GetDefaultValue(AM.LinearGradientBrush.EndPointProperty.OwnerType);
                    }
                    break;
                case nameof(StartPoint):
                    if (!Equals(StartPoint, value))
                    {
                        StartPoint = (global::Avalonia.RelativePoint?)value;
                        NativeControl.StartPoint = StartPoint ?? (global::Avalonia.RelativePoint)AM.LinearGradientBrush.StartPointProperty.GetDefaultValue(AM.LinearGradientBrush.StartPointProperty.OwnerType);
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
