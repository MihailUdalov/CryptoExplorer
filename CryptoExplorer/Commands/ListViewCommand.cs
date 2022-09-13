using CryptoExplorer.APINameCryptoProviders;
using CryptoExplorer.ViewModel;
using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;

namespace CryptoExplorer.Commands
{
    internal class ListViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            CoinCapProvider provider = new CoinCapProvider();
            if (parameter is object[] homeControls)
            {
                if (homeControls.LastOrDefault() is ListViewCommandType listViewCommandType)
                {
                    switch (listViewCommandType)
                    {
                        case ListViewCommandType.Search:
                            ((ListView)homeControls.FirstOrDefault()).ItemsSource = provider.GetDataCryptoCoins().Cryptocurrencies.Where(x => x.Name.Contains(((TextBox)homeControls[1]).Text));
                            break;
                        case ListViewCommandType.Refrech:
                            ((ListView)homeControls.FirstOrDefault()).ItemsSource = provider.GetDataCryptoCoins().Cryptocurrencies.Take(10);
                            break;
                        default:
                            break;

                    }
                }
            }
        }      
    }
}
