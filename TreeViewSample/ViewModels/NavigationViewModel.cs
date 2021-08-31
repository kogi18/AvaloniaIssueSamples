using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using JetBrains.Annotations;
using ReactiveUI;

namespace TreeViewSample.ViewModels
{
    public class NavigationViewModel : ViewModelBase
    {
        [CanBeNull] private HierarchyNodeViewModel selected_subhierarchy_ = null;

        public ObservableCollection<HierarchyNodeViewModel> TreeHierarchy { get; } = new();

        public ICommand AddChild { get; }

        public NavigationViewModel()
        {
            
            AddChild = ReactiveCommand.Create(() => {
                selected_subhierarchy_.Children.Add(new HierarchyNodeViewModel(string.Format($"Manual {selected_subhierarchy_.Count}"), this));
            });
            
            
            var gen = new Random();
            for (var i = 0; i < 5; i++)
            {
                var current = new HierarchyNodeViewModel(string.Format($"Option {i}"), this);
                for (var j = 0; j < gen.Next(1, 10); j++)
                {
                    current.Children.Add(new HierarchyNodeViewModel(string.Format($"Child {j}"), this));
                }
                TreeHierarchy.Add(current);
            }
        }
        
        public HierarchyNodeViewModel SelectedHierarchyElement {
            get => selected_subhierarchy_;
            set {
                this.RaiseAndSetIfChanged(ref selected_subhierarchy_, value);
            }
        }

    }
}