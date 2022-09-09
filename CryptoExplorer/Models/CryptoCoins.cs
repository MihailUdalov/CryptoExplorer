﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExplorer.Models
{
    public class CryptoCoins
    {
        public List<DataCoin> Data { get; set; }
        public static DataCoin DetailDataCoin { get; set; }
    }
    public class DataCoin
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

        public override string ToString()
        {
            return $"{Rank} {Name} {PriceUsd}";
        }
    }
}
