using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasActores.ViewModels
{
    class SubVM : INotifyPropertyChanged
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
