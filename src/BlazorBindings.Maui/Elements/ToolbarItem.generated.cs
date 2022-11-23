// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class ToolbarItem : MenuItem
    {
        static ToolbarItem()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets a value that indicates on which of the primary, secondary, or default toolbar surfaces to display this <see cref="T:Microsoft.Maui.Controls.ToolbarItem" /> element.
        /// </summary>
        [Parameter] public MC.ToolbarItemOrder? Order { get; set; }
        /// <summary>
        /// Gets or sets the priority of this <see cref="T:Microsoft.Maui.Controls.ToolbarItem" /> element.
        /// </summary>
        [Parameter] public int? Priority { get; set; }

        public new MC.ToolbarItem NativeControl => (MC.ToolbarItem)((BindableObject)this).NativeControl;

        protected override MC.ToolbarItem CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Order):
                    if (!Equals(Order, value))
                    {
                        Order = (MC.ToolbarItemOrder?)value;
                        NativeControl.Order = Order ?? default;
                    }
                    break;
                case nameof(Priority):
                    if (!Equals(Priority, value))
                    {
                        Priority = (int?)value;
                        NativeControl.Priority = Priority ?? default;
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
