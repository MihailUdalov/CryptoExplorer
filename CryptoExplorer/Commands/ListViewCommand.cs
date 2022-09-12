using CryptoExplorer.Models;
using CryptoExplorer.State.Navigators;
using CryptoExplorer.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace CryptoExplorer.Commands
{
    internal class ListViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public INavigator _navigator;

        public ListViewCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is object[] homeControls)
            {
                if (homeControls.LastOrDefault() is ListViewCommandType listViewCommandType)
                {
                    switch (listViewCommandType)
                    {
                        case ListViewCommandType.Search:
                            ((ListView)homeControls.FirstOrDefault()).ItemsSource = GetCryptoCoins().Data.Where(x => x.Name.Contains(((TextBox)homeControls[1]).Text));
                            break;
                        case ListViewCommandType.Refrech:
                            ((ListView)homeControls.FirstOrDefault()).ItemsSource = GetCryptoCoins().Data.Take(10);
                            break;
                        default:
                            break;

                    }
                }
            }
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
