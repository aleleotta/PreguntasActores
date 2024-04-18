using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class clsRespuesta
    {
        #region Attributes
        private readonly int id = 0;
        private string frase = "";
        private int idPregunta = 0;
        #endregion

        #region Properties
        public int Id { get { return id; } }
        public string Frase { get {  return frase; } }
        public int IdPregunta { get {  return idPregunta; } }
        #endregion

        #region Constructors
        public clsRespuesta() { }
        public clsRespuesta(int id, string frase, int idPregunta)
        {
            this.id = id;
            this.frase = frase;
            this.idPregunta = idPregunta;
        }
        #endregion
    }
}
