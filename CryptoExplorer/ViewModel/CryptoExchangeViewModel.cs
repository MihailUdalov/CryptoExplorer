using CryptoExplorer.APINameCryptoProviders;
using CryptoExplorer.Commands;
using System.Windows.Input;

namespace CryptoExplorer.ViewModel
{
    public class CryptoExchangeViewModel:ViewModelBase
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
        public ICommand ExchangeCommand => new ExchangeCommand();

        public CryptoExchangeViewModel()
        {
            CoinCapProvider provider = new CoinCapProvider();
            Coins = provider.GetDataCryptoCoins();
        }
       

    }
}
