using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DAL;
using Entities;
using PreguntasActores.Models;
using PreguntasActores.Utilities;

namespace PreguntasActores.ViewModels
{
    internal class MainVM : INotifyPropertyChanged
    {
        #region Attributes
        private ObservableCollection<clsActorNombreCompleto> listadoActores;
        private ObservableCollection<clsActorNombreCompleto> listadoCuatroActores;
        private clsActorNombreCompleto actorActual; // El actor a adivinar.
        private clsActorNombreCompleto actorSeleccionado;
        private int jugadas = 0;
        private int aciertos = 0;
        private int equivocados = 0;
        private DelegateCommand jugar;
        private DelegateCommand confirmar;
        private DelegateCommand salir;
        #endregion

        #region Properties
        public ObservableCollection<clsActorNombreCompleto> ListadoCuatroActores { get { return listadoCuatroActores; } }
        public clsActorNombreCompleto ActorActual { get { return actorActual; } }
        public clsActorNombreCompleto ActorSeleccionado
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
        public int Jugadas { get { return jugadas; } }
        public int Aciertos { get { return aciertos; } }
        public int Equivocados { get { return equivocados; } }
        public DelegateCommand Jugar { get { return jugar; } }
        public DelegateCommand Confirmar { get { return confirmar; } }
        public DelegateCommand Salir { get { return salir; } }
        #endregion

        #region CommandExecuters
        private async void jugar_execute()
        {
            jugadas = 0; aciertos = 0; equivocados = 0;
            await Shell.Current.GoToAsync("///Partido");
        }

        private void confirmar_execute()
        {

        }

        private bool confirmar_canExecute()
        {
            if (actorSeleccionado != null) return true;
            else return false;
        }

        private void salir_execute() => System.Environment.Exit(0);
        #endregion

        #region Constructor
        public MainVM()
        {
            getListadoActoresNombreCompleto();
            jugar = new DelegateCommand(jugar_execute);
            confirmar = new DelegateCommand(confirmar_execute, confirmar_canExecute);
            salir = new DelegateCommand(salir_execute);
            getListadoCuatroActores();
        }
        #endregion

        #region Methods
        private void getListadoCuatroActores()
        {
            listadoCuatroActores = new ObservableCollection<clsActorNombreCompleto>();
            Random random = new Random();
            while (listadoCuatroActores.Count < 4)
            {
                clsActorNombreCompleto actor = listadoActores[random.Next(listadoActores.Count)];
                if (!listadoCuatroActores.Contains(actor) && actor.Jugado == false)
                {
                    listadoCuatroActores.Add(actor);
                }
            }
            actorActual = listadoCuatroActores[random.Next(1, 4)];
            OnPropertyChanged("ActorActual");
            OnPropertyChanged("ListadoCuatroActores");
        }

        private void getListadoActoresNombreCompleto()
        {
            List<clsActor> listado = clsListadosDAL.getListadoCompletoActores();
            listadoActores = new ObservableCollection<clsActorNombreCompleto>();
            foreach (clsActor actor in listado)
            {
                clsActorNombreCompleto actorConNombre = new clsActorNombreCompleto(actor);
                listadoActores.Add(actorConNombre);
            }
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