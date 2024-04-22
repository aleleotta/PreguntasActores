using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
        private clsActor actorActual; // El actor a adivinar.
        private clsActor actorSeleccionado;
        private int aciertos = 0;
        private DelegateCommand jugar;
        private DelegateCommand seleccionarRespuesta;
        private DelegateCommand confirmar;
        private DelegateCommand salir;
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
        public int Aciertos { get { return aciertos; } }
        public DelegateCommand Jugar { get { return jugar; } }
        public DelegateCommand SeleccionarRespuesta { get { return seleccionarRespuesta; } }
        public DelegateCommand Confirmar { get { return confirmar; } }
        public DelegateCommand Salir { get { return salir; } }
        #endregion

        #region CommandExecuters
        private async void jugar_execute()
        {
            await Shell.Current.GoToAsync("///Partido");
            listadoCuatroActores = new ObservableCollection<clsActor>();
            Random random = new Random();
            for (int i = 1; i <= 4; i++)
            {
                listadoCuatroActores.Add(listadoActores[random.Next(listadoActores.Count)]);
            }
            actorActual = listadoCuatroActores[random.Next(1,4)];
            OnPropertyChanged("ActorActual");
            OnPropertyChanged("ListadoCuatroActores");
        }

        private void seleccionarRespuesta_execute() { }
        private bool seleccionarRespuesta_canExecute() { return true; }
        private void confirmar_execute() { }
        private void salir_execute() => System.Environment.Exit(0);
        #endregion

        #region Constructor
        public MainVM()
        {
            listadoActores = new ObservableCollection<clsActor>(clsListadosDAL.getListadoCompletoActores());
            jugar = new DelegateCommand(jugar_execute);
            seleccionarRespuesta = new DelegateCommand(seleccionarRespuesta_execute, seleccionarRespuesta_canExecute);
            confirmar = new DelegateCommand(confirmar_execute);
            salir = new DelegateCommand(salir_execute);
        }
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}