// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using AC = Avalonia.Controls;
using BlazorBindings.Core;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    /// <summary>
    /// Displays <see cref="P:Avalonia.Controls.ContentControl.Content" /> according to an <see cref="T:Avalonia.Controls.Templates.IDataTemplate" />.
    /// </summary>
    public partial class ContentControl : BlazorBindings.AvaloniaBindings.Elements.Primitives.TemplatedControl
    {
        static ContentControl()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the content to display.
        /// </summary>
        [Parameter] public object Content { get; set; }
        /// <summary>
        /// Gets or sets the data template used to display the content of the control.
        /// </summary>
        [Parameter] public AC.Templates.IDataTemplate ContentTemplate { get; set; }
        /// <summary>
        /// Gets or sets the horizontal alignment of the content within the control.
        /// </summary>
        [Parameter] public global::Avalonia.Layout.HorizontalAlignment? HorizontalContentAlignment { get; set; }
        /// <summary>
        /// Gets or sets the vertical alignment of the content within the control.
        /// </summary>
        [Parameter] public global::Avalonia.Layout.VerticalAlignment? VerticalContentAlignment { get; set; }

        public new AC.ContentControl NativeControl => (AC.ContentControl)((BindableObject)this).NativeControl;

        protected override AC.ContentControl CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(Content):
                    if (!Equals(Content, value))
                    {
                        Content = (object)value;
                        NativeControl.Content = Content;
                    }
                    break;
                case nameof(ContentTemplate):
                    if (!Equals(ContentTemplate, value))
                    {
                        ContentTemplate = (AC.Templates.IDataTemplate)value;
                        NativeControl.ContentTemplate = ContentTemplate;
                    }
                    break;
                case nameof(HorizontalContentAlignment):
                    if (!Equals(HorizontalContentAlignment, value))
                    {
                        HorizontalContentAlignment = (global::Avalonia.Layout.HorizontalAlignment?)value;
                        NativeControl.HorizontalContentAlignment = HorizontalContentAlignment ?? (global::Avalonia.Layout.HorizontalAlignment)AC.ContentControl.HorizontalContentAlignmentProperty.GetDefaultValue(AC.ContentControl.HorizontalContentAlignmentProperty.OwnerType);
                    }
                    break;
                case nameof(VerticalContentAlignment):
                    if (!Equals(VerticalContentAlignment, value))
                    {
                        VerticalContentAlignment = (global::Avalonia.Layout.VerticalAlignment?)value;
                        NativeControl.VerticalContentAlignment = VerticalContentAlignment ?? (global::Avalonia.Layout.VerticalAlignment)AC.ContentControl.VerticalContentAlignmentProperty.GetDefaultValue(AC.ContentControl.VerticalContentAlignmentProperty.OwnerType);
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
