using CryptoExplorer.Models;
using CryptoExplorer.ViewModel;
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

            DataContext = CreateViewToShow(StaticDataCryptoCoins.DetailsCryptoCoin);
        }

        public DataCoin CreateViewToShow(DataCoin dataCoin)
        {
            dataCoin.ID = "ID: " + dataCoin.ID;
            dataCoin.Rank = "Rank: " + dataCoin.Rank;
            dataCoin.Symbol = "Symbol: " + dataCoin.Symbol;
            dataCoin.Supply = "Supply: " + Math.Round(Convert.ToDecimal(dataCoin.Supply), 3).ToString();
            dataCoin.MaxSupply = "MaxSupply: " + Math.Round(Convert.ToDecimal(dataCoin.MaxSupply), 3).ToString();

            dataCoin.MarketCapUsd = "MarketCapUsd: " + Math.Round(Convert.ToDecimal(dataCoin.MarketCapUsd), 3).ToString();
            dataCoin.VolumeUsd24Hr = "VolumeUsd24Hr: " + Math.Round(Convert.ToDecimal(dataCoin.VolumeUsd24Hr), 3).ToString();
            dataCoin.PriceUsd = "PriceUsd: " + Math.Round(Convert.ToDecimal(dataCoin.PriceUsd), 3).ToString() + "$";
            dataCoin.ChangePercent24Hr = "ChangePercent24Hr: " + Math.Round(Convert.ToDecimal(dataCoin.ChangePercent24Hr), 3).ToString();
            dataCoin.Vwap24Hr = "Vwap24Hr: " + Math.Round(Convert.ToDecimal(dataCoin.Vwap24Hr), 3).ToString();

            return dataCoin;
        }
    }
}
