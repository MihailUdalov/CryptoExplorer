using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExplorer.ViewModel
{
    public class ViewModelLocator
    {
        public static HomeViewModel HomeViewModel { get; set; } = new HomeViewModel();
        public static CryptoDetailsViewModel CryptoDetailsViewModel { get; set; } = new CryptoDetailsViewModel();
        public static InformationViewModel InformationViewModel { get; set; } = new InformationViewModel();
        public static CryptoExchangeViewModel CryptoExchangeViewModel { get; set; } = new CryptoExchangeViewModel();
        public static MainViewModel MainViewModel { get; set; } = new MainViewModel();
    }
}
