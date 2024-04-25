using PreguntasActores.Models;
using PreguntasActores.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasActores.ViewModels
{
    class SubVM : INotifyPropertyChanged, IQueryAttributable
    {
        #region Attributes
        private clsEstatistica estatistica;
        private DelegateCommand jugar;
        private DelegateCommand salir;
        #endregion

        #region Properties
        public clsEstatistica Estatistica { get { return estatistica; } }
        public DelegateCommand Jugar { get { return jugar; } }
        public DelegateCommand Salir { get { return salir; } }
        #endregion

        #region CommandExecuters
        private async void jugar_execute()
        {
            estatistica.Aciertos = 0; estatistica.Equivocados = 0;
            await Shell.Current.GoToAsync("///Partido");
        }

        private void salir_execute() => System.Environment.Exit(0);
        #endregion

        #region Methods
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            estatistica = query["Estatisticas"] as clsEstatistica;
            OnPropertyChanged("Estatistica");
        }
        #endregion

        #region Constructors
        public SubVM()
        {
            jugar = new DelegateCommand(jugar_execute);
            salir = new DelegateCommand(salir_execute);
        }
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
