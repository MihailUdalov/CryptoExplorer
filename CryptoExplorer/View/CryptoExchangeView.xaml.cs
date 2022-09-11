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
        public CryptoCoins CryptoDataCoins { get; set; }

        public CryptoExchangeView()
        {
            InitializeComponent();

            CryptoDataCoins = GetCryptoCoins();
            FirstCryptoCoinComboBox.ItemsSource = CryptoDataCoins.Data;
            FirstCryptoCoinComboBox.SelectedItem = CryptoDataCoins.Data.FirstOrDefault();

            SecondtCryptoCoinComboBox.ItemsSource = CryptoDataCoins.Data;
            SecondtCryptoCoinComboBox.SelectedItem = CryptoDataCoins.Data.FirstOrDefault();
        }

        private CryptoCoins GetCryptoCoins()
        {
            const string URL = "https://api.coincap.io/v2/assets";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<CryptoCoins>(response);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FirstCryptoCoinComboBox.SelectedItem is DataCoin firstCryptoCoin 
                && SecondtCryptoCoinComboBox.SelectedItem is DataCoin secondCryptoCoin 
                && Convert.ToDecimal(FirstTextBox.Text) is decimal count)
                
                SecondtTextBox.Text = Math.Round((Convert.ToDecimal(firstCryptoCoin.PriceUsd) * count) / Convert.ToDecimal(secondCryptoCoin.PriceUsd), 8).ToString();
            
        }
    }
}
