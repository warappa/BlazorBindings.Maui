// <auto-generated>
//     This code was generated by a BlazorBindings.Maui component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using BlazorBindings.Core;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Maui;
using System;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    /// <summary>
    /// A <see cref="T:Microsoft.Maui.Controls.VisualElement" /> that occupies the entire screen.
    /// </summary>
    public partial class Page : VisualElement
    {
        static Page()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public MC.ImageSource BackgroundImageSource { get; set; }
        [Parameter] public MC.ImageSource IconImageSource { get; set; }
        /// <summary>
        /// Marks the Page as busy. This will cause the platform specific global activity indicator to show a busy state.
        /// </summary>
        /// <value>
        /// A bool indicating if the Page is busy or not.
        /// </value>
        [Parameter] public bool? IsBusy { get; set; }
        /// <summary>
        /// The space between the content of the <see cref="T:Microsoft.Maui.Controls.Page" /> and it's border.
        /// </summary>
        [Parameter] public Thickness? Padding { get; set; }
        /// <summary>
        /// The <see cref="T:Microsoft.Maui.Controls.Page" />'s title.
        /// </summary>
        [Parameter] public string Title { get; set; }
        [Parameter] public RenderFragment MenuBarItems { get; set; }
        /// <summary>
        /// A set of <see cref="T:Microsoft.Maui.Controls.ToolbarItem" />s, implemented in a platform-specific manner.
        /// </summary>
        [Parameter] public RenderFragment ToolbarItems { get; set; }
        [Parameter] public EventCallback<MC.NavigatedToEventArgs> OnNavigatedTo { get; set; }
        [Parameter] public EventCallback<MC.NavigatingFromEventArgs> OnNavigatingFrom { get; set; }
        [Parameter] public EventCallback<MC.NavigatedFromEventArgs> OnNavigatedFrom { get; set; }
        [Parameter] public EventCallback OnLayoutChanged { get; set; }
        [Parameter] public EventCallback OnAppearing { get; set; }
        [Parameter] public EventCallback OnDisappearing { get; set; }

        public new MC.Page NativeControl => (MC.Page)((BindableObject)this).NativeControl;

        protected override MC.Page CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(BackgroundImageSource):
                    if (!Equals(BackgroundImageSource, value))
                    {
                        BackgroundImageSource = (MC.ImageSource)value;
                        NativeControl.BackgroundImageSource = BackgroundImageSource;
                    }
                    break;
                case nameof(IconImageSource):
                    if (!Equals(IconImageSource, value))
                    {
                        IconImageSource = (MC.ImageSource)value;
                        NativeControl.IconImageSource = IconImageSource;
                    }
                    break;
                case nameof(IsBusy):
                    if (!Equals(IsBusy, value))
                    {
                        IsBusy = (bool?)value;
                        NativeControl.IsBusy = IsBusy ?? (bool)MC.Page.IsBusyProperty.DefaultValue;
                    }
                    break;
                case nameof(Padding):
                    if (!Equals(Padding, value))
                    {
                        Padding = (Thickness?)value;
                        NativeControl.Padding = Padding ?? (Thickness)MC.Page.PaddingProperty.DefaultValue;
                    }
                    break;
                case nameof(Title):
                    if (!Equals(Title, value))
                    {
                        Title = (string)value;
                        NativeControl.Title = Title;
                    }
                    break;
                case nameof(MenuBarItems):
                    MenuBarItems = (RenderFragment)value;
                    break;
                case nameof(ToolbarItems):
                    ToolbarItems = (RenderFragment)value;
                    break;
                case nameof(OnNavigatedTo):
                    if (!Equals(OnNavigatedTo, value))
                    {
                        void NativeControlNavigatedTo(object sender, MC.NavigatedToEventArgs e) => InvokeEventCallback(OnNavigatedTo, e);

                        OnNavigatedTo = (EventCallback<MC.NavigatedToEventArgs>)value;
                        NativeControl.NavigatedTo -= NativeControlNavigatedTo;
                        NativeControl.NavigatedTo += NativeControlNavigatedTo;
                    }
                    break;
                case nameof(OnNavigatingFrom):
                    if (!Equals(OnNavigatingFrom, value))
                    {
                        void NativeControlNavigatingFrom(object sender, MC.NavigatingFromEventArgs e) => InvokeEventCallback(OnNavigatingFrom, e);

                        OnNavigatingFrom = (EventCallback<MC.NavigatingFromEventArgs>)value;
                        NativeControl.NavigatingFrom -= NativeControlNavigatingFrom;
                        NativeControl.NavigatingFrom += NativeControlNavigatingFrom;
                    }
                    break;
                case nameof(OnNavigatedFrom):
                    if (!Equals(OnNavigatedFrom, value))
                    {
                        void NativeControlNavigatedFrom(object sender, MC.NavigatedFromEventArgs e) => InvokeEventCallback(OnNavigatedFrom, e);

                        OnNavigatedFrom = (EventCallback<MC.NavigatedFromEventArgs>)value;
                        NativeControl.NavigatedFrom -= NativeControlNavigatedFrom;
                        NativeControl.NavigatedFrom += NativeControlNavigatedFrom;
                    }
                    break;
                case nameof(OnLayoutChanged):
                    if (!Equals(OnLayoutChanged, value))
                    {
                        void NativeControlLayoutChanged(object sender, EventArgs e) => InvokeEventCallback(OnLayoutChanged);

                        OnLayoutChanged = (EventCallback)value;
                        NativeControl.LayoutChanged -= NativeControlLayoutChanged;
                        NativeControl.LayoutChanged += NativeControlLayoutChanged;
                    }
                    break;
                case nameof(OnAppearing):
                    if (!Equals(OnAppearing, value))
                    {
                        void NativeControlAppearing(object sender, EventArgs e) => InvokeEventCallback(OnAppearing);

                        OnAppearing = (EventCallback)value;
                        NativeControl.Appearing -= NativeControlAppearing;
                        NativeControl.Appearing += NativeControlAppearing;
                    }
                    break;
                case nameof(OnDisappearing):
                    if (!Equals(OnDisappearing, value))
                    {
                        void NativeControlDisappearing(object sender, EventArgs e) => InvokeEventCallback(OnDisappearing);

                        OnDisappearing = (EventCallback)value;
                        NativeControl.Disappearing -= NativeControlDisappearing;
                        NativeControl.Disappearing += NativeControlDisappearing;
                    }
                    break;

                default:
                    base.HandleParameter(name, value);
                    break;
            }
        }

        protected override void RenderAdditionalElementContent(RenderTreeBuilder builder, ref int sequence)
        {
            base.RenderAdditionalElementContent(builder, ref sequence);
            RenderTreeBuilderHelper.AddListContentProperty<MC.Page, MC.MenuBarItem>(builder, sequence++, MenuBarItems, x => x.MenuBarItems);
            RenderTreeBuilderHelper.AddListContentProperty<MC.Page, MC.ToolbarItem>(builder, sequence++, ToolbarItems, x => x.ToolbarItems);
        }

        static partial void RegisterAdditionalHandlers();
    }
}
