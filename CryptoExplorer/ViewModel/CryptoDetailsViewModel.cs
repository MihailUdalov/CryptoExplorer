using CryptoExplorer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExplorer.ViewModel
{
    public class CryptoDetailsViewModel : ViewModelBase
    {
        public static DataCoin CryptoCoin;
        public CryptoDetailsViewModel(string coinName)
        {
            CryptoCoins cryptoCoins = new CryptoCoins();
            CryptoCoin = GetCryptoCoin().Data.FirstOrDefault(x => x.Name == coinName);
        }

        private CryptoCoins GetCryptoCoin()
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
