using Entities;

namespace DAL
{
    public class clsListadosDAL
    {
        public static List<clsActor> getListadoCompletoActores()
        {
            List<clsActor> listadoActores = new List<clsActor>
            {
                new clsActor()
            };
            return listadoActores;
        }
        public static List<clsPregunta> getListadoCompletoPreguntas()
        {
            List<clsPregunta> listadoPreguntas = new List<clsPregunta>
            {
                new clsPregunta()
            };
            return listadoPreguntas;
        }
        public static List<clsRespuesta> getListadoCompletoRespuestas()
        {
            List<clsRespuesta> listadoRespuestas = new List<clsRespuesta>
            {
                new clsRespuesta()
            };
            return listadoRespuestas;
        }
        public static clsActor getActorPorId(int idActor)
        {
            return new clsActor();
        }
        public static clsPregunta getPreguntaPorId(int idPregunta)
        {
            return new clsPregunta();
        }
        public static clsRespuesta getRespuestaPorId(int idRespuesta)
        {
            return new clsRespuesta();
        }
    }
}