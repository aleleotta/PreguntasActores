namespace Entities
{
    public class clsActor
    {
        #region Attributes
        private readonly int id = 0;
        private string nombre = "";
        private string apellidos = "";
        private string foto = "";
        #endregion

        #region Properties
        public int Id { get { return id; } }
        public string Nombre { get {  return nombre; } }
        public string Apellidos { get {  return apellidos; } }
        public string Foto { get { return foto; } }
        #endregion

        #region Constructors
        public clsActor() { }
        public clsActor(int id, string nombre, string apellidos)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        public clsActor(int id, string nombre, string apellidos, string foto)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.foto = foto;
        }
        public clsActor(clsActor actor)
        {
            this.id = actor.Id;
            this.nombre = actor.Nombre;
            this.apellidos = actor.Apellidos;
            this.foto = actor.Foto;
        }
        #endregion
    }
}
