using CryptoExplorer.State.Navigators;
using CryptoExplorer.View;
using CryptoExplorer.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoExplorer.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            string coinName = "";
            if (parameter is IEnumerable<object> enumrable)
            {
                parameter = enumrable.FirstOrDefault();
                coinName = enumrable.Last().ToString();
            }
            if(parameter is ViewType viewType)
            {
                switch(viewType)
                {
                    case ViewType.Info:
                        _navigator.CurrentViewModel = new InformationViewModel();
                        break;
                    case ViewType.Home:
                        _navigator.CurrentViewModel = new HomeViewModel();
                        break;
                    case ViewType.CryptoDetails:  
                        _navigator.CurrentViewModel = new CryptoDetailsViewModel(coinName);
                        break;
                    case ViewType.CryptoExchange:
                        _navigator.CurrentViewModel = new CryptoExchangeViewModel();
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
