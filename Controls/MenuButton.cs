using Avalonia;
using Avalonia.Controls;

namespace Phantomex.Client.Desktop.Controls
{
    public class MenuButton : Button
    {
        static MenuButton()
        {
            AffectsRender<MenuButton>(
                IsSelectedProperty
            );
        }
        
        public static readonly StyledProperty<bool> IsSelectedProperty =
            AvaloniaProperty.Register<MenuButton, bool>("IsSelected", false);
        
        public bool IsSelected
        {
            get => GetValue(IsSelectedProperty);
            set => SetValue(IsSelectedProperty, value);
        }
    }
}