namespace Entities
{
    public class clsActor
    {
        #region Attributes
        private readonly int id = 0;
        private string nombre = "";
        private string apellidos = "";
        private DateTime fechaNac;
        private string nacionalidad = "";
        private string foto = "";
        #endregion

        #region Properties
        public int Id { get { return id; } }
        public string Nombre { get {  return nombre; } }
        public string Apellidos { get {  return apellidos; } }
        public DateTime FechaNac { get {  return fechaNac; } }
        public string Nacionalidad { get { return nacionalidad; } }
        public string Foto { get { return foto; } }
        #endregion

        #region Constructors
        public clsActor() { }
        public clsActor(int id, string nombre, string apellidos, DateTime fechaNac, string nacionalidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nacionalidad = nacionalidad;
        }
        public clsActor(int id, string nombre, string apellidos, DateTime fechaNac, string nacionalidad, string foto)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nacionalidad = nacionalidad;
            this.foto = foto;
        }
        #endregion
    }
}
