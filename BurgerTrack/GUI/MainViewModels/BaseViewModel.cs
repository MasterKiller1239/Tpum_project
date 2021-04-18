using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GUI.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        #region Properties

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        #endregion
    }
}
