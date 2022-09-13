using CryptoExplorer.ViewModel;
using System.Windows;

namespace CryptoExplorer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Window window = new MainWindow();
            window.DataContext = new HomeViewModel();

            window.Show();
                
            base.OnStartup(e);
        }

    }
}
