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
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class ContentView : TemplatedView
    {
        static ContentView()
        {
            ElementHandlerRegistry.RegisterPropertyContentHandler<ContentView>(nameof(ChildContent),
                (renderer, parent, component) => new ContentPropertyHandler<MC.ContentView>((x, value) => x.Content = (MC.View)value));
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the content of the ContentView.
        /// </summary>
        /// <value>
        /// A <see cref="T:Microsoft.Maui.Controls.View" /> that contains the content.
        /// </value>
        [Parameter] public RenderFragment ChildContent { get; set; }

        public new MC.ContentView NativeControl => (MC.ContentView)((BindableObject)this).NativeControl;

        protected override MC.ContentView CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
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
            RenderTreeBuilderHelper.AddContentProperty(builder, sequence++, typeof(ContentView), ChildContent);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
