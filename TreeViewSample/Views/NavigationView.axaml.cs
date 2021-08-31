using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TreeViewSample.Views
{
    public partial class NavigationView : UserControl
    {
        public NavigationView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}