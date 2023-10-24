// <auto-generated>
//     This code was generated by a BlazorBindings.Avalonia component generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>

using ACP = Avalonia.Controls.Primitives;
using BlazorBindings.AvaloniaBindings.Elements;

#pragma warning disable CA2252

namespace BlazorBindings.AvaloniaBindings.Elements.Primitives
{
    /// <summary>
    /// Represents a control that a user can select (check) or clear (uncheck). Base class for controls that can switch states.
    /// </summary>
    public partial class ToggleButton : BlazorBindings.AvaloniaBindings.Elements.Button
    {
        static ToggleButton()
        {
            RegisterAdditionalHandlers();
        }

        /// <summary>
        /// Gets or sets whether the <see cref="T:Avalonia.Controls.Primitives.ToggleButton" /> is checked.
        /// </summary>
        [Parameter] public Nullable<bool> IsChecked { get; set; }
        /// <summary>
        /// Gets or sets a value that indicates whether the control supports three states.
        /// </summary>
        [Parameter] public bool? IsThreeState { get; set; }
        [Parameter] public EventCallback<Nullable<bool>> IsCheckedChanged { get; set; }

        public new ACP.ToggleButton NativeControl => (ACP.ToggleButton)((AvaloniaObject)this).NativeControl;

        protected override ACP.ToggleButton CreateNativeElement() => new();

        protected override void HandleParameter(string name, object value)
        {
            switch (name)
            {
                case nameof(IsChecked):
                    if (!Equals(IsChecked, value))
                    {
                        IsChecked = (Nullable<bool>)value;
                        NativeControl.IsChecked = IsChecked;
                    }
                    break;
                case nameof(IsThreeState):
                    if (!Equals(IsThreeState, value))
                    {
                        IsThreeState = (bool?)value;
                        NativeControl.IsThreeState = IsThreeState ?? (bool)ACP.ToggleButton.IsThreeStateProperty.GetDefaultValue(ACP.ToggleButton.IsThreeStateProperty.OwnerType);
                    }
                    break;
                case nameof(IsCheckedChanged):
                    if (!Equals(IsCheckedChanged, value))
                    {
                        void NativeControlIsCheckedChanged(object sender, global::Avalonia.Interactivity.RoutedEventArgs e)
                        {
                            var value = NativeControl.IsChecked;
                            IsChecked = value;
                            InvokeEventCallback(IsCheckedChanged, value);
                        }

                        IsCheckedChanged = (EventCallback<Nullable<bool>>)value;
                        NativeControl.IsCheckedChanged -= NativeControlIsCheckedChanged;
                        NativeControl.IsCheckedChanged += NativeControlIsCheckedChanged;
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
