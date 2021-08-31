using Avalonia.Dialogs;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace TreeViewSample.ViewModels
{
    public class HierarchyNodeViewModel : ViewModelBase
    {
        public NavigationViewModel Parent { get; }

        public string Name { get; set; }
        public string Count { get => string.Format($"[{Children.Count}]"); }
        public ObservableCollection<HierarchyNodeViewModel> Children { get; } = new();

        public HierarchyNodeViewModel()
        {
        }

        public HierarchyNodeViewModel(string name, NavigationViewModel parent) : this()
        {
            Name = name;
            Parent = parent;
        }
    }
}