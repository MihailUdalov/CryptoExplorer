using CryptoExplorer.Commands;
using CryptoExplorer.Models;
using CryptoExplorer.ViewModel;
using System.Windows.Input;

namespace CryptoExplorer.State.Navigators
{
    public enum ViewType
    {
       Home,
       Info,
       CryptoExchange,
       CryptoDetails
    }


    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;
        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);


        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel ?? new HomeViewModel();
            }
            set
            {
                _currentViewModel = value;
                OnProperyChange(nameof(CurrentViewModel));
            }
        }
    }
}
