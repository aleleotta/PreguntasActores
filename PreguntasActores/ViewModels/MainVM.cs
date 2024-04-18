using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities

namespace PreguntasActores.ViewModels
{
    internal class MainVM : INotifyPropertyChanged
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}