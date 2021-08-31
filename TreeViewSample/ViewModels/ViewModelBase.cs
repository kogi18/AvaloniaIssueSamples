using System.ComponentModel;
using System.Runtime.CompilerServices;
using ReactiveUI;

namespace TreeViewSample.ViewModels
{
    public class ViewModelBase : ReactiveObject, INotifyPropertyChanged {}
    class TextViewModel : INotifyPropertyChanged {
        private string path_ = string.Empty;

        public string Path {
            get => path_;
            set {
                if (value != path_) {
                    path_ = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string property_name = null) {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property_name));
        }
    }
}
