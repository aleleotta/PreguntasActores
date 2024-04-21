using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using PreguntasActores.Utilities;

namespace PreguntasActores.ViewModels
{
    internal class MainVM : INotifyPropertyChanged
    {
        #region Attributes
        private ObservableCollection<clsActor> listadoActores;
        private ObservableCollection<clsActor> listadoCuatroActores;
        private clsActor actorActual;
        private clsActor actorSeleccionado;
        private DelegateCommand seleccionarRespuesta;
        #endregion

        #region Properties
        public ObservableCollection<clsActor> ListadoCuatroActores { get { return listadoCuatroActores; } }
        public clsActor ActorActual { get { return actorActual; } }
        public clsActor ActorSeleccionado
        {
            get
            {
                return actorSeleccionado;
            }
            set
            {
                actorSeleccionado = value;
                OnPropertyChanged("ActorSeleccionado");
            }
        }
        #endregion

        #region Constructor
        public MainVM()
        {
            listadoActores = new ObservableCollection<clsActor>(clsListadosDAL.getListadoCompletoActores());
        }
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}