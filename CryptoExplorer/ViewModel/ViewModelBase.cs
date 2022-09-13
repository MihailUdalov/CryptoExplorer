using CryptoExplorer.State.Navigators;
using System.ComponentModel;

namespace CryptoExplorer.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static INavigator Navigator { get; set; } = new Navigator();

    }
}
