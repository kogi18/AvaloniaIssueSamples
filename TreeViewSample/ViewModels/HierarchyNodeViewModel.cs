using System.Collections.ObjectModel;

namespace TreeViewSample.ViewModels
{
    public class HierarchyNodeViewModel : ViewModelBase
    {
        public string Name { get; set; }
        public string Count { get => string.Format($"[{Children.Count}]"); }
        public ObservableCollection<HierarchyNodeViewModel> Children { get; } = new();

        public HierarchyNodeViewModel(){}

        public HierarchyNodeViewModel(string name) : this()
        {
            Name = name;
        }
    }
}