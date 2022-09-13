using System;
using System.Windows.Input;
using System.Diagnostics;
using System.Windows.Controls;

namespace CryptoExplorer.Commands
{
    internal class FollowTheLinkCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = ((TextBlock)parameter).Tag.ToString(),
                UseShellExecute = true
            });
        }
    }
}
