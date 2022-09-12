using CryptoExplorer.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;

namespace CryptoExplorer.View
{
    /// <summary>
    /// Interaction logic for CryptoExchangeView.xaml
    /// </summary>
    public partial class CryptoExchangeView : UserControl
    {
        public CryptoExchangeView()
        {
            InitializeComponent();


            StaticDataCryptoCoins.RefrechCryptoCoinData();

            FirstCryptoCoinComboBox.ItemsSource = StaticDataCryptoCoins.CryptoCoins.Data;
            FirstCryptoCoinComboBox.SelectedItem = StaticDataCryptoCoins.CryptoCoins.Data.FirstOrDefault();

            SecondCryptoCoinComboBox.ItemsSource = StaticDataCryptoCoins.CryptoCoins.Data;
            SecondCryptoCoinComboBox.SelectedItem = StaticDataCryptoCoins.CryptoCoins.Data.FirstOrDefault();
        }
    }
}
