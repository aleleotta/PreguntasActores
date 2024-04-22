﻿using System.Collections.ObjectModel;
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
        private clsActor actorActual; // El actor a adivinar.
        private clsActor actorSeleccionado;
        private int jugadas = 0;
        private int aciertos = 0;
        private int equivocados = 0;
        private DelegateCommand jugar;
        private DelegateCommand<string> seleccionarRespuesta;
        private DelegateCommand confirmar;
        private DelegateCommand salir;
        #endregion

        #region Properties
        public ObservableCollection<clsActorNombreCompleto> ListadoCuatroActores { get { return listadoCuatroActores; } }
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
        public int Jugadas { get { return jugadas; } }
        public int Aciertos { get { return aciertos; } }
        public int Equivocados { get { return equivocados; } }
        public DelegateCommand Jugar { get { return jugar; } }
        public DelegateCommand<string> SeleccionarRespuesta { get { return seleccionarRespuesta; } }
        public DelegateCommand Confirmar { get { return confirmar; } }
        public DelegateCommand Salir { get { return salir; } }
        #endregion

        #region CommandExecuters
        private async void jugar_execute()
        {
            await Shell.Current.GoToAsync("///Partido");
        }

        private void seleccionarRespuesta_execute(string prop)
        {
            foreach (clsActorNombreCompleto actor in listadoCuatroActores)
            {
                if (actor.NombreCompleto.Equals(prop))
                {
                    actorSeleccionado = actor;
                }
            }
        }
        private bool seleccionarRespuesta_canExecute(string prop)
        {
            if (actorSeleccionado != null) return true;
            else return false;
        }
        private void confirmar_execute() { }
        private void salir_execute() => System.Environment.Exit(0);
        #endregion

        #region Constructor
        public MainVM()
        {
            getListadoActoresNombreCompleto();
            jugar = new DelegateCommand(jugar_execute);
            seleccionarRespuesta = new DelegateCommand<string>(seleccionarRespuesta_execute, seleccionarRespuesta_canExecute);
            confirmar = new DelegateCommand(confirmar_execute);
            salir = new DelegateCommand(salir_execute);
            getListadoCuatroActores();
        }
        #endregion

        #region Methods
        private void getListadoCuatroActores()
        {
            listadoCuatroActores = new ObservableCollection<clsActorNombreCompleto>();
            Random random = new Random();
            for (int i = 1; i <= 4; i++)
            {
                clsActorNombreCompleto actor = listadoActores[random.Next(listadoActores.Count)];
                do
                {
                    if (actor.Jugado == false)
                    {
                        listadoCuatroActores.Add(listadoActores[random.Next(listadoActores.Count)]);
                    }
                    actor = listadoActores[random.Next(listadoActores.Count)];
                }
                while (actor.Jugado == true);
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