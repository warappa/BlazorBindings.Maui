// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class BaseShellItem : NavigableElement
    {
        static BaseShellItem()
        {
            RegisterAdditionalHandlers();
        }

        [Parameter] public MC.ImageSource FlyoutIcon { get; set; }
        [Parameter] public bool FlyoutItemIsVisible { get; set; }
        [Parameter] public MC.ImageSource Icon { get; set; }
        [Parameter] public bool IsEnabled { get; set; }
        [Parameter] public bool IsVisible { get; set; }
        [Parameter] public string Route { get; set; }
        [Parameter] public string Title { get; set; }
        [Parameter] public EventCallback OnAppearing { get; set; }
        [Parameter] public EventCallback OnDisappearing { get; set; }

        public new MC.BaseShellItem NativeControl => (MC.BaseShellItem)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MC.BaseShellItem();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(FlyoutIcon):
                    if (!Equals(FlyoutIcon, value))
                    {
                        FlyoutIcon = (MC.ImageSource)value;
                        NativeControl.FlyoutIcon = FlyoutIcon;
                    }
                    break;
                case nameof(FlyoutItemIsVisible):
                    if (!Equals(FlyoutItemIsVisible, value))
                    {
                        FlyoutItemIsVisible = (bool)value;
                        NativeControl.FlyoutItemIsVisible = FlyoutItemIsVisible;
                    }
                    break;
                case nameof(Icon):
                    if (!Equals(Icon, value))
                    {
                        Icon = (MC.ImageSource)value;
                        NativeControl.Icon = Icon;
                    }
                    break;
                case nameof(IsEnabled):
                    if (!Equals(IsEnabled, value))
                    {
                        IsEnabled = (bool)value;
                        NativeControl.IsEnabled = IsEnabled;
                    }
                    break;
                case nameof(IsVisible):
                    if (!Equals(IsVisible, value))
                    {
                        IsVisible = (bool)value;
                        NativeControl.IsVisible = IsVisible;
                    }
                    break;
                case nameof(Route):
                    if (!Equals(Route, value))
                    {
                        Route = (string)value;
                        NativeControl.Route = Route;
                    }
                    break;
                case nameof(Title):
                    if (!Equals(Title, value))
                    {
                        Title = (string)value;
                        NativeControl.Title = Title;
                    }
                    break;
                case nameof(OnAppearing):
                    if (!Equals(OnAppearing, value))
                    {
                        void NativeControlAppearing(object sender, System.EventArgs e) => OnAppearing.InvokeAsync();

                        OnAppearing = (EventCallback)value;
                        NativeControl.Appearing -= NativeControlAppearing;
                        NativeControl.Appearing += NativeControlAppearing;
                    }
                    break;
                case nameof(OnDisappearing):
                    if (!Equals(OnDisappearing, value))
                    {
                        void NativeControlDisappearing(object sender, System.EventArgs e) => OnDisappearing.InvokeAsync();

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

        partial void RenderAdditionalAttributes(AttributesBuilder builder);
        static partial void RegisterAdditionalHandlers();
    }
}
