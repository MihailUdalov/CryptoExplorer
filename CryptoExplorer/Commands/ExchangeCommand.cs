using CryptoExplorer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace CryptoExplorer.Commands
{
    internal class ExchangeCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            List<ComboBox> comboBoxes = new List<ComboBox>();
            List<TextBox> textBoxes = new List<TextBox>();
            if (parameter is object[] enumrable)
            {
                for (int i = 0; i < enumrable.Length; i++)
                {
                    switch (enumrable[i])
                    {
                        case TextBox:
                            textBoxes.Add((TextBox)enumrable[i]);
                            break;
                        case ComboBox:
                            comboBoxes.Add((ComboBox)enumrable[i]);
                            break;
                        default:
                            break;
                    }
                }
            }
            if (textBoxes[0].Text != "" && comboBoxes[0].SelectedItem is DataCoin firstCryptoCoin
                && comboBoxes[1].SelectedItem is DataCoin secondCryptoCoin
                && Convert.ToDecimal(textBoxes[0].Text) is decimal count)

                textBoxes[1].Text = Math.Round((Convert.ToDecimal(firstCryptoCoin.PriceUsd) * count) / Convert.ToDecimal(secondCryptoCoin.PriceUsd), 8).ToString();
           
        }
    }
}
