using System.ComponentModel;

namespace CryptoExplorer.Models
{
    public class ObservableObject : INotifyPropertyChanged
    {   
            
        protected void OnProperyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
