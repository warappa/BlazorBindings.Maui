// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>



#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements
{
    /// <summary>
    /// Provides the base class for defining a new control that encapsulates related existing controls and provides its own logic.
    /// </summary>
    public partial class UserControl : ContentControl
    {
        static UserControl()
        {
            RegisterAdditionalHandlers();
        }

        public new AC.UserControl NativeControl => (AC.UserControl)((AvaloniaObject)this).NativeControl;

        protected override AC.UserControl CreateNativeElement() => new();


        static partial void RegisterAdditionalHandlers();
    }
}
