// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using ACS = Avalonia.Controls.Shapes;
using BlazorBindings.AvaloniaBindings.Elements;
using System.Collections.Generic;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements.Shapes
{
    public partial class Polyline : Shape
    {
        static Polyline()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public IList<global::Avalonia.Point> Points { get; set; }

        public new ACS.Polyline NativeControl => (ACS.Polyline)((AvaloniaObject)this).NativeControl;

        protected override ACS.Polyline CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Points):
                    if (!Equals(Points, value))
                    {
                        Points = (IList<global::Avalonia.Point>)value;
                        NativeControl.Points = Points;
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
