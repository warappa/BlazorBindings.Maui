// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using AC = Avalonia.Controls;
using BlazorBindings.Core;
using Microsoft.AspNetCore.Components;
using System.Collections;
using System.Threading.Tasks;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    /// <summary>
    /// Displays a collection of items.
    /// </summary>
    public partial class ItemsControl : BlazorBindings.AvaloniaBindings.Elements.Primitives.TemplatedControl
    {
        static ItemsControl()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets the <see cref="T:Avalonia.Data.IBinding" /> to use for binding to the display member of each item.
        /// </summary>
        [Parameter] public global::Avalonia.Data.IBinding DisplayMemberBinding { get; set; }
        /// <summary>
        /// Gets or sets the <see cref="T:Avalonia.Styling.ControlTheme" /> that is applied to the container element generated for each item.
        /// </summary>
        [Parameter] public global::Avalonia.Styling.ControlTheme ItemContainerTheme { get; set; }
        /// <summary>
        /// Gets or sets the panel used to display the items.
        /// </summary>
        [Parameter] public AC.ITemplate<AC.Panel> ItemsPanel { get; set; }
        /// <summary>
        /// Gets or sets a collection used to generate the content of the <see cref="T:Avalonia.Controls.ItemsControl" />.
        /// </summary>
        [Parameter] public IEnumerable ItemsSource { get; set; }
        /// <summary>
        /// Gets or sets the data template used to display the items in the control.
        /// </summary>
        [Parameter] public AC.Templates.IDataTemplate ItemTemplate { get; set; }
        [Parameter] public EventCallback<AC.ContainerPreparedEventArgs> OnContainerPrepared { get; set; }
        [Parameter] public EventCallback<AC.ContainerIndexChangedEventArgs> OnContainerIndexChanged { get; set; }
        [Parameter] public EventCallback<AC.ContainerClearingEventArgs> OnContainerClearing { get; set; }

        public new AC.ItemsControl NativeControl => (AC.ItemsControl)((BindableObject)this).NativeControl;

        protected override AC.ItemsControl CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(DisplayMemberBinding):
                    if (!Equals(DisplayMemberBinding, value))
                    {
                        DisplayMemberBinding = (global::Avalonia.Data.IBinding)value;
                        NativeControl.DisplayMemberBinding = DisplayMemberBinding;
                    }
                    break;
                case nameof(ItemContainerTheme):
                    if (!Equals(ItemContainerTheme, value))
                    {
                        ItemContainerTheme = (global::Avalonia.Styling.ControlTheme)value;
                        NativeControl.ItemContainerTheme = ItemContainerTheme;
                    }
                    break;
                case nameof(ItemsPanel):
                    if (!Equals(ItemsPanel, value))
                    {
                        ItemsPanel = (AC.ITemplate<AC.Panel>)value;
                        NativeControl.ItemsPanel = ItemsPanel;
                    }
                    break;
                case nameof(ItemsSource):
                    if (!Equals(ItemsSource, value))
                    {
                        ItemsSource = (IEnumerable)value;
                        NativeControl.ItemsSource = ItemsSource;
                    }
                    break;
                case nameof(ItemTemplate):
                    if (!Equals(ItemTemplate, value))
                    {
                        ItemTemplate = (AC.Templates.IDataTemplate)value;
                        NativeControl.ItemTemplate = ItemTemplate;
                    }
                    break;
                case nameof(OnContainerPrepared):
                    if (!Equals(OnContainerPrepared, value))
                    {
                        void NativeControlContainerPrepared(object sender, AC.ContainerPreparedEventArgs e) => InvokeEventCallback(OnContainerPrepared, e);

                        OnContainerPrepared = (EventCallback<AC.ContainerPreparedEventArgs>)value;
                        NativeControl.ContainerPrepared -= NativeControlContainerPrepared;
                        NativeControl.ContainerPrepared += NativeControlContainerPrepared;
                    }
                    break;
                case nameof(OnContainerIndexChanged):
                    if (!Equals(OnContainerIndexChanged, value))
                    {
                        void NativeControlContainerIndexChanged(object sender, AC.ContainerIndexChangedEventArgs e) => InvokeEventCallback(OnContainerIndexChanged, e);

                        OnContainerIndexChanged = (EventCallback<AC.ContainerIndexChangedEventArgs>)value;
                        NativeControl.ContainerIndexChanged -= NativeControlContainerIndexChanged;
                        NativeControl.ContainerIndexChanged += NativeControlContainerIndexChanged;
                    }
                    break;
                case nameof(OnContainerClearing):
                    if (!Equals(OnContainerClearing, value))
                    {
                        void NativeControlContainerClearing(object sender, AC.ContainerClearingEventArgs e) => InvokeEventCallback(OnContainerClearing, e);

                        OnContainerClearing = (EventCallback<AC.ContainerClearingEventArgs>)value;
                        NativeControl.ContainerClearing -= NativeControlContainerClearing;
                        NativeControl.ContainerClearing += NativeControlContainerClearing;
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
