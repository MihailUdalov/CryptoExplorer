using CryptoExplorer.Commands;
using System.Windows.Input;

namespace CryptoExplorer.ViewModel
{
    public enum ThemeType
    {
        Dark,
        White
    }

    public class MainViewModel: ViewModelBase
    {

        public static bool Hidden = true;

        public ICommand ShowHideMenuCommand => new ShowHideMenuCommand();
        public ICommand CloseWindow => new CloseWindowCommand();
        public ICommand MinimazeWindow => new MinimazeWindowCommand();
    }
}
