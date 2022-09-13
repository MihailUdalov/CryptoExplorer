using CryptoExplorer.APINameCryptoProviders;
using System;
using System.Collections.Generic;
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
            if (parameter is object[] objects)
            {
                for (int i = 0; i < objects.Length; i++)
                {
                    switch (objects[i])
                    {
                        case TextBox:
                            textBoxes.Add((TextBox)objects[i]);
                            break;
                        case ComboBox:
                            comboBoxes.Add((ComboBox)objects[i]);
                            break;
                        default:
                            break;
                    }
                }

                if (string.IsNullOrEmpty(textBoxes[0].Text) && comboBoxes[0].SelectedItem is Cryptocurrency firstCryptoCoin
                    && comboBoxes[1].SelectedItem is Cryptocurrency secondCryptoCoin
                    && Convert.ToDecimal(textBoxes[0].Text) is decimal count)

                    textBoxes[1].Text = Math.Round((Convert.ToDecimal(firstCryptoCoin.PriceUsd) * count) / Convert.ToDecimal(secondCryptoCoin.PriceUsd), 8).ToString();
            }
           
        }
    }
}
