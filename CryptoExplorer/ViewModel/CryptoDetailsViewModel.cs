using CryptoExplorer.APINameCryptoProviders;
using CryptoExplorer.Commands;
using System;
using System.Windows.Input;

namespace CryptoExplorer.ViewModel
{
    public class CryptoDetailsViewModel : ViewModelBase
    {
        private CryptocurrencyDateil _coin;
        public CryptocurrencyDateil Coin
        {
            get { return _coin; }
            set
            {
                _coin = value;
                NotifyPropertyChanged("Coin");
            }
        }
        public ICommand FollowTheLinkCommand => new FollowTheLinkCommand();
        public CryptoDetailsViewModel()
        {

        }
        public CryptoDetailsViewModel(string coinID)
        {
            CoinCapProvider coinCapProvider = new CoinCapProvider(); 
            Coin = coinCapProvider.GetDetailsDataCryptoCoin(coinID);

            Coin.CryptocurrenciesDetail.Supply = Math.Round(Convert.ToDecimal(Coin.CryptocurrenciesDetail.Supply), 3).ToString();
            Coin.CryptocurrenciesDetail.MaxSupply = Math.Round(Convert.ToDecimal(Coin.CryptocurrenciesDetail.MaxSupply), 3).ToString();

            Coin.CryptocurrenciesDetail.MarketCapUsd =  Math.Round(Convert.ToDecimal(Coin.CryptocurrenciesDetail.MarketCapUsd), 3).ToString();
            Coin.CryptocurrenciesDetail.VolumeUsd24Hr = Math.Round(Convert.ToDecimal(Coin.CryptocurrenciesDetail.VolumeUsd24Hr), 3).ToString();
            Coin.CryptocurrenciesDetail.PriceUsd = Math.Round(Convert.ToDecimal(Coin.CryptocurrenciesDetail.PriceUsd), 3).ToString("C5");
            Coin.CryptocurrenciesDetail.ChangePercent24Hr = Math.Round(Convert.ToDecimal(Coin.CryptocurrenciesDetail.ChangePercent24Hr), 3).ToString();
            Coin.CryptocurrenciesDetail.Vwap24Hr = Math.Round(Convert.ToDecimal(Coin.CryptocurrenciesDetail.Vwap24Hr), 3).ToString();
        }
        
        
    }
}
