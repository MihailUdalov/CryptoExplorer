using System.Linq;
using CryptoExplorer.Commands;
using System.Windows.Input;
using CryptoExplorer.APINameCryptoProviders;

namespace CryptoExplorer.ViewModel
{
    public enum ListViewCommandType
    {
        Search,
        Refrech
    }

    public class HomeViewModel : ViewModelBase
    {
        private CryptocurrencyCollection _coins;

        public CryptocurrencyCollection Coins
        {
            get { return _coins; }
            set
            {
                _coins = value;
                NotifyPropertyChanged("Coins");
            }
        }
        public ICommand ListViewCommand => new ListViewCommand();
        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(Navigator);

        public HomeViewModel()
        {
            CoinCapProvider provider = new CoinCapProvider();
            Coins = new CryptocurrencyCollection();
            Coins.Cryptocurrencies = provider.GetDataCryptoCoins().Cryptocurrencies.Take(10).ToList();

        
        }
    }
}
