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
using Plugin.Maui.Audio;
using PreguntasActores.Utilities;

namespace PreguntasActores.ViewModels
{
    internal class MainVM : INotifyPropertyChanged
    {
        #region Attributes
        private ObservableCollection<clsActor> listadoActores;
        private ObservableCollection<clsPregunta> listadoPreguntas;
        private ObservableCollection<clsRespuesta> listadoRespuestas;
        private IAudioManager audioManager;
        private clsPregunta preguntaActual;
        private clsRespuesta respuestaSeleccionada;
        private DelegateCommand cambiarRespuesta;
        #endregion

        #region Properties
        public ObservableCollection<clsPregunta> ListadoPreguntas { get { return listadoPreguntas; } }
        public ObservableCollection<clsRespuesta> ListadoRespuestas { get { return listadoRespuestas; } }
        public clsPregunta PreguntaActual { get { return preguntaActual; } }
        public clsRespuesta RespuestaSeleccionada
        {
            get
            {
                return respuestaSeleccionada;
            }
            set
            {
                respuestaSeleccionada = value;
                OnPropertyChanged("RespuestaSeleccionada");
            }
        }
        #endregion

        #region Constructor
        public MainVM()
        {
            listadoActores = new ObservableCollection<clsActor>(clsListadosDAL.getListadoCompletoActores());
            listadoPreguntas = new ObservableCollection<clsPregunta>(clsListadosDAL.getListadoCompletoPreguntas());
            listadoRespuestas = new ObservableCollection<clsRespuesta>(clsListadosDAL.getListadoCompletoRespuestas());
        }
        #endregion

        #region ViewModel
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}