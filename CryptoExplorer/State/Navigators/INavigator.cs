using CryptoExplorer.Commands;
using CryptoExplorer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoExplorer.State.Navigators
{
    public interface INavigator
    {
        public ViewModelBase CurrentViewModel { get; set; }
        public ICommand UpdateCurrentViewModelCommand { get; }

    }
}
