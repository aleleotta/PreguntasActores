using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasActores.Models
{
    public class clsActorNombreCompleto : clsActor
    {
        private string nombreCompleto;
        private bool jugado = false;

        public string NombreCompleto { get { return nombreCompleto; } }
        public bool Jugado { get { return jugado; } set { jugado = value; } }

        public clsActorNombreCompleto(clsActor actor) : base(actor)
        {
            nombreCompleto = $"{Nombre} {Apellidos}";
        }
    }
}
