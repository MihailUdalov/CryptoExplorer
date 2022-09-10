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

            this.DataContext = CryptoDetailsViewModel.CryptoCoin;

            CryptoDetailsViewModel.CryptoCoin.ID = "ID: " + CryptoDetailsViewModel.CryptoCoin.ID;
            CryptoDetailsViewModel.CryptoCoin.Rank = "Rank: " + CryptoDetailsViewModel.CryptoCoin.Rank;
            CryptoDetailsViewModel.CryptoCoin.Symbol = "Symbol: " + CryptoDetailsViewModel.CryptoCoin.Symbol;
            CryptoDetailsViewModel.CryptoCoin.Supply = "Supply: " + Math.Round(Convert.ToDecimal(CryptoDetailsViewModel.CryptoCoin.Supply),3).ToString();
            CryptoDetailsViewModel.CryptoCoin.MaxSupply = "MaxSupply: " + Math.Round(Convert.ToDecimal(CryptoDetailsViewModel.CryptoCoin.MaxSupply),3).ToString();

            CryptoDetailsViewModel.CryptoCoin.MarketCapUsd = "MarketCapUsd: " + Math.Round(Convert.ToDecimal(CryptoDetailsViewModel.CryptoCoin.MarketCapUsd),3).ToString();
            CryptoDetailsViewModel.CryptoCoin.VolumeUsd24Hr = "VolumeUsd24Hr: " + Math.Round(Convert.ToDecimal(CryptoDetailsViewModel.CryptoCoin.VolumeUsd24Hr),3).ToString();
            CryptoDetailsViewModel.CryptoCoin.PriceUsd = "PriceUsd: " + Math.Round(Convert.ToDecimal(CryptoDetailsViewModel.CryptoCoin.PriceUsd),3).ToString() + "$";
            CryptoDetailsViewModel.CryptoCoin.ChangePercent24Hr = "ChangePercent24Hr: " + Math.Round(Convert.ToDecimal(CryptoDetailsViewModel.CryptoCoin.ChangePercent24Hr),3).ToString();
            CryptoDetailsViewModel.CryptoCoin.Vwap24Hr = "Vwap24Hr: " + Math.Round(Convert.ToDecimal(CryptoDetailsViewModel.CryptoCoin.Vwap24Hr), 3).ToString();
        }
    }
}
