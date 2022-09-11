using CryptoExplorer.State.Navigators;
using CryptoExplorer.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CryptoExplorer.Commands
{
    internal class UpdateThemeCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public INavigator _navigator;

        public UpdateThemeCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ThemeType themeType)
            {
                switch (themeType)
                {
                    case ThemeType.Dark:
                        ChangeTheme(@"/Resources/Styles/DarkTheme.xaml");
                        break;
                    case ThemeType.White:
                        ChangeTheme(@"/Resources/Styles/WhiteTheme.xaml");
                        break;
                    default:
                        break;

                }
            }
        }

        private void ChangeTheme(string theme)
        {
            var uri = new Uri(theme, UriKind.Relative);
            ResourceDictionary resourceDictionary = Application.LoadComponent(uri) as ResourceDictionary;
            //Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
        }
    }
}
