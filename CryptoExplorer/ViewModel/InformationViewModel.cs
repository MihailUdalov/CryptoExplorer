using CryptoExplorer.Commands;
using System.Windows.Input;

namespace CryptoExplorer.ViewModel
{
    public class InformationViewModel : ViewModelBase
    {
        public InformationViewModel()
        {

        }
        public ICommand UpdateThemeCommand => new UpdateThemeCommand();
    }
}
