using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExplorer.Models
{
    public static class StaticDataCryptoCoins
    {
        public static CryptoCoins CryptoCoins { get; set; }

        public static DataCoin DetailsCryptoCoin { get; set; }
        public static void RefrechCryptoCoinData()
        {
            const string URL = "https://api.coincap.io/v2/assets";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            CryptoCoins = JsonConvert.DeserializeObject<CryptoCoins>(response);
        }
    }
}
