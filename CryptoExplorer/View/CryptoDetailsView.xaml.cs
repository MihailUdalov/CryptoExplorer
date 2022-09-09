using CryptoExplorer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CryptoExplorer.View
{
    /// <summary>
    /// Interaction logic for CryptoDetailsView.xaml
    /// </summary>
    public partial class CryptoDetailsView : UserControl
    {
        public CryptoDetailsView()
        {
            InitializeComponent();

            CoinName.Text = CryptoCoins.DetailDataCoin.Name;
            CoinID.Text = "ID: " + CryptoCoins.DetailDataCoin.ID;
            CoinRank.Text = "Rank: " + CryptoCoins.DetailDataCoin.Rank;
            CoinSymbol.Text = "Symbol: " + CryptoCoins.DetailDataCoin.Symbol;
            CoinSupply.Text = "Supply: " + Math.Round(Convert.ToDecimal(CryptoCoins.DetailDataCoin.Supply),3).ToString();
            CoinMaxSupply.Text = "MaxSupply: " + Math.Round(Convert.ToDecimal(CryptoCoins.DetailDataCoin.MaxSupply),3).ToString();

            CoinMarketCapUsd.Text = "MarketCapUsd: " + Math.Round(Convert.ToDecimal(CryptoCoins.DetailDataCoin.MarketCapUsd),3).ToString();
            CoinVolumeUsd24Hr.Text = "VolumeUsd24Hr: " + Math.Round(Convert.ToDecimal(CryptoCoins.DetailDataCoin.VolumeUsd24Hr),3).ToString();
            CoinPriceUsd.Text = "PriceUsd: " + Math.Round(Convert.ToDecimal(CryptoCoins.DetailDataCoin.PriceUsd),3).ToString() + "$";
            CoinChangePercent24Hr.Text = "ChangePercent24Hr: " + Math.Round(Convert.ToDecimal(CryptoCoins.DetailDataCoin.ChangePercent24Hr),3).ToString();
            CoinVwap24Hr.Text = "Vwap24Hr: " + Math.Round(Convert.ToDecimal(CryptoCoins.DetailDataCoin.Vwap24Hr), 3).ToString();
        }
    }
}
