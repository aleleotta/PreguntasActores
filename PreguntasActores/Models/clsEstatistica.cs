using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasActores.Models
{
    class clsEstatistica
    {
        private int aciertos;
        private int equivocados;

        public int Aciertos { get { return aciertos; } set { aciertos = value; } }
        public int Equivocados { get {  return equivocados; } set { equivocados = value; } }

        public clsEstatistica() { }
        public clsEstatistica(int aciertos, int equivocados)
        {
            this.aciertos = aciertos;
            this.equivocados = equivocados;
        }
    }
}
