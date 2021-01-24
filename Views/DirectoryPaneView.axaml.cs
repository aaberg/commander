using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Aaberg.Commander.Views
{
    public class DirectoryPaneView : UserControl
    {
        public DirectoryPaneView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}