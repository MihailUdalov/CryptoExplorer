using CryptoExplorer.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace CryptoExplorer.Commands
{
    internal class ShowHideMenuCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var resourceDictionary = new ResourceDictionary() { Source = new Uri("../Resources/Storyboards/MenuStoryboards.xaml", UriKind.RelativeOrAbsolute) };
            Storyboard sb = (MainViewModel.Hidden ? resourceDictionary["sbShowMenu"] : resourceDictionary["sbHideMenu"]) as Storyboard;

            sb.Begin((Grid)parameter);
            MainViewModel.Hidden = !MainViewModel.Hidden;
        }
    }
}
