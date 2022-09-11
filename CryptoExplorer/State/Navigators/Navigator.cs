using CryptoExplorer.Commands;
using CryptoExplorer.Models;
using CryptoExplorer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public enum ThemeType
    {
        Dark,
        White
    }

    public class Navigator : ObservableObject, INavigator
    {
        private ViewModelBase _currentViewModel;
        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
        public ICommand UpdateThemeCommand => new UpdateThemeCommand(this);
        public ICommand CloseWindow => new CloseWindowCommand();
        public ICommand MinimazeWindow => new MinimazeWindowCommand();



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
