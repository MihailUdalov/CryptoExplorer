﻿using CryptoExplorer.Models;
using Newtonsoft.Json;
using System;
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
            CryptoDataCoins = GetCryptoCoins();
            
            CoinsList.ItemsSource = CryptoDataCoins.Data.Take(10);
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
    }
}