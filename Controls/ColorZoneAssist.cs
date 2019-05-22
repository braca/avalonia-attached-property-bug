namespace AvaloniaAttachedProperty.Controls
{
    using Avalonia;
    using Avalonia.Controls;

    public static class ColorZoneAssist
    {
        public static AvaloniaProperty<ColorZoneMode> ModeProperty = AvaloniaProperty.RegisterAttached<GroupBox, ColorZoneMode>("Mode", typeof(ColorZoneAssist), inherits: true);

        public static ColorZoneMode GetMode(Control control)
        {
            return control.GetValue(ModeProperty);
        }

        public static void SetMode(Control control, ColorZoneMode value)
        {
            control.SetValue(ModeProperty, value);
        }
    }

    public enum ColorZoneMode
    {
        Standard,
        Inverted,
        PrimaryLight,
        PrimaryMid,
        PrimaryDark,
        Accent,
        Light,
        Dark
    }
}
