using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class clsPregunta
    {
        #region Attributes
        private readonly int id = 0;
        private string frase = "";
        private int idRespuestaCorrecta = 0;
        #endregion

        #region Properties
        public int Id { get { return id; } }
        public string Frase { get {  return frase; } }
        public int IdRespuestaCorrecta { get {  return idRespuestaCorrecta; } }
        #endregion

        #region Constructors
        public clsPregunta() { }
        public clsPregunta(int id, string frase, int idRespuestaCorrecta)
        {
            this.id = id;
            this.frase = frase;
            this.idRespuestaCorrecta = idRespuestaCorrecta;
        }
        #endregion
    }
}
