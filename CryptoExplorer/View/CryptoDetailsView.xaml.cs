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
        public DataCoin DataCryptoCoin { get; set; }
        public CryptoDetailsView()
        {
            DataCryptoCoin = CryptoCoins.DetailDataCoin;
            InitializeComponent();
        }
    }
}
