﻿using System;
using System.Windows;
using System.Windows.Input;

namespace CryptoExplorer.Commands
{
    internal class CloseWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Application.Current.MainWindow.Close();
        }
    }
}
