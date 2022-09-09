using CryptoExplorer.Models;
using CryptoExplorer.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public CryptoCoins CryptoDataCoins { get; set; }
        public HomeView()
        {
            InitializeComponent();
            PushToListView();
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

        public void PushToListView()
        {        
            CryptoDataCoins = GetCryptoCoins();

            CoinsList.ItemsSource = CryptoDataCoins.Data.Take(10);
        }

        private void CoinSearchButton_Click(object sender, RoutedEventArgs e)
        {
            CoinsList.ItemsSource = CryptoDataCoins.Data.Where(x => x.Name.Contains(CoinSearchTextBox.Text));
        }

        private void RefrechListViewButton_Click(object sender, RoutedEventArgs e)
        {
            PushToListView();
        }
        private void DetailsButton_Click(object sender, RoutedEventArgs e)
        {
            string nameCoin = (sender as Button)?.Tag.ToString();
            DataCoin CryptoCoin = CryptoDataCoins.Data.FirstOrDefault(x => x.Name == nameCoin);
            CryptoCoins.DetailDataCoin = CryptoCoin;
            HomeViewModel.Navigator.CurrentViewModel = new CryptoDetailsViewModel();
        }
    }
}
