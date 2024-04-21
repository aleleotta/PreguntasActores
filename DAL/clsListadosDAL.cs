using Entities;

namespace DAL
{
    public class clsListadosDAL
    {
        public static List<clsActor> getListadoCompletoActores()
        {
            List<clsActor> listadoActores = new List<clsActor>
            {
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor(),
                new clsActor()
            };
            return listadoActores;
        }
        
        public static clsActor getActorPorId(int idActor)
        {
            return new clsActor();
        }
    }
}