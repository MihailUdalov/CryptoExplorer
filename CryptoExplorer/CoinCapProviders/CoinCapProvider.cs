using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace CryptoExplorer.APINameCryptoProviders
{
    public class CoinCapProvider
    {
        private readonly static string URL = "https://api.coincap.io/v2/assets";
        public  CryptocurrencyCollection GetDataCryptoCoins()
        {
            
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                string response = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<CryptocurrencyCollection>(response);
            }

            
        }

        public  CryptocurrencyDateil GetDetailsDataCryptoCoin(string coinID)
        { 

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create($"{URL}/{coinID}");

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                string response = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<CryptocurrencyDateil>(response);
            }
        }
    }
}
