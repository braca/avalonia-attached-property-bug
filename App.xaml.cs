using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaAttachedProperty
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
