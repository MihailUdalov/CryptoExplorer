using CryptoExplorer.ViewModel;
using System.Windows.Input;

namespace CryptoExplorer.State.Navigators
{
    public interface INavigator
    {
        public ViewModelBase CurrentViewModel { get; set; }
        public ICommand UpdateCurrentViewModelCommand { get; }

    }
}
