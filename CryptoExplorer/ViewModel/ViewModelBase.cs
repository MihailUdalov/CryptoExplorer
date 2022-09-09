using CryptoExplorer.State.Navigators;
using CryptoExplorer.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExplorer.ViewModel
{
    public class ViewModelBase
    {
        public INavigator Navigator { get; set; } = new Navigator();
    }
}
