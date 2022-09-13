using Newtonsoft.Json;
using System.Collections.Generic;

namespace CryptoExplorer.APINameCryptoProviders
{
    public class CryptocurrencyCollection
    {
        [JsonProperty("data", Required = Required.Always)]
        public List<Cryptocurrency> Cryptocurrencies { get; set; }
    }
    public class Cryptocurrency
    {
        public string ID { get; set; }
        public string Rank { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Supply { get; set; }
        public string MaxSupply { get; set; }
        public string MarketCapUsd { get; set; }
        public string VolumeUsd24Hr { get; set; }
        public string PriceUsd { get; set; }
        public string ChangePercent24Hr { get; set; }
        public string Vwap24Hr { get; set; }
    }
}
