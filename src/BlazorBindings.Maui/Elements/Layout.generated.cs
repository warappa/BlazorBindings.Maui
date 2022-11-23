// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Maui;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public abstract partial class Layout : View
    {
        static Layout()
        {
            ElementHandlerRegistry.RegisterPropertyContentHandler<Layout>(nameof(ChildContent),
                (renderer, parent, component) => new ListContentPropertyHandler<MC.Layout, IView>(x => x.Children));
            RegisterAdditionalHandlers();
        }

        [Parameter] public bool? CascadeInputTransparent { get; set; }
        [Parameter] public bool? IgnoreSafeArea { get; set; }
        /// <summary>
        /// Gets or sets a value which determines if the Layout should clip its children to its bounds.
        /// </summary>
        /// <value>
        /// <see langword="true" /> if the Layout is clipped; otherwise, <see langword="false" />. The default value is <see langword="false" />.
        /// </value>
        [Parameter] public bool? IsClippedToBounds { get; set; }
        /// <summary>
        /// Gets or sets the inner padding of the Layout.
        /// </summary>
        /// <value>
        /// The Thickness values for the layout. The default value is a Thickness with all values set to 0.
        /// </value>
        [Parameter] public Thickness? Padding { get; set; }
        /// <summary>
        /// For internal use by the Microsoft.Maui.Controls platform.
        /// </summary>
        [Parameter] public RenderFragment ChildContent { get; set; }

        public new MC.Layout NativeControl => (MC.Layout)((BindableObject)this).NativeControl;


        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(CascadeInputTransparent):
                    if (!Equals(CascadeInputTransparent, value))
                    {
                        CascadeInputTransparent = (bool?)value;
                        NativeControl.CascadeInputTransparent = CascadeInputTransparent ?? (bool)MC.Layout.CascadeInputTransparentProperty.DefaultValue;
                    }
                    break;
                case nameof(IgnoreSafeArea):
                    if (!Equals(IgnoreSafeArea, value))
                    {
                        IgnoreSafeArea = (bool?)value;
                        NativeControl.IgnoreSafeArea = IgnoreSafeArea ?? default;
                    }
                    break;
                case nameof(IsClippedToBounds):
                    if (!Equals(IsClippedToBounds, value))
                    {
                        IsClippedToBounds = (bool?)value;
                        NativeControl.IsClippedToBounds = IsClippedToBounds ?? (bool)MC.Layout.IsClippedToBoundsProperty.DefaultValue;
                    }
                    break;
                case nameof(Padding):
                    if (!Equals(Padding, value))
                    {
                        Padding = (Thickness?)value;
                        NativeControl.Padding = Padding ?? (Thickness)MC.Layout.PaddingProperty.DefaultValue;
                    }
                    break;
                case nameof(ChildContent):
                    ChildContent = (RenderFragment)value;
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(Layout), ChildContent);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
