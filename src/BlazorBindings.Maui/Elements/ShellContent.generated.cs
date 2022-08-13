// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BlazorBindings.Core;
using BlazorBindings.Maui.Elements.Handlers;
using MC = Microsoft.Maui.Controls;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorBindings.Maui.Elements
{
    public partial class ShellContent : BaseShellItem
    {
        static ShellContent()
        {
            RegisterAdditionalHandlers();
        }

        public new MC.ShellContent NativeControl => (MC.ShellContent)((Element)this).NativeControl;

        protected override MC.Element CreateNativeElement() => new MC.ShellContent();


        partial void RenderAdditionalAttributes(AttributesBuilder builder);
        static partial void RegisterAdditionalHandlers();
    }
}
