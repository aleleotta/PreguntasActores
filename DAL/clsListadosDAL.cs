using Entities;

namespace DAL
{
    public class clsListadosDAL
    {
        /// <summary>
        /// Devuelve el listado completo de actores con todos los datos rellenados.
        /// </summary>
        /// <returns>El listado completo de actores</returns>
        public static List<clsActor> getListadoCompletoActores()
        {
            List<clsActor> listadoActores = new List<clsActor>
            {
                new clsActor(1, "Al Pacino", "", "al_pacino.jpg"),
                new clsActor(2, "Andrew", "Lincoln", "andrew_lincoln.jpg"),
                new clsActor(3, "Brad", "Pitt", "brad_pitt.jpg"),
                new clsActor(4, "Chris", "Evans", "chris_evans.jpg"),
                new clsActor(5, "Chris", "Hemsworth", "chris_hemsworth.jpg"),
                new clsActor(6, "Cillian", "Murphy", "cillian_murphy.jpg"),
                new clsActor(7, "Jeffrey", "Dean Morgan", "jeffrey_dean_morgan.jpg"),
                new clsActor(8, "Joaquin", "Phoenix", "joaquin_phoenix.jpg"),
                new clsActor(9, "Johnny", "Depp", "johnny_depp.jpg"),
                new clsActor(10, "Jon", "Bernthal", "jon_bernthal.jpg"),
                new clsActor(11, "Keanu", "Reeves", "keanu_reeves.jpg"),
                new clsActor(12, "Leonardo", "DiCaprio", "leonardo_dicaprio.jpg"),
                new clsActor(13, "Liam", "Neeson", "liam_neeson.jpg"),
                new clsActor(14, "Mads", "Mikkelsen", "mads_mikkelsen.jpg"),
                new clsActor(15, "Michael", "Rooker", "michael_rooker.jpg"),
                new clsActor(16, "Norman", "Reedus", "norman_reedus.jpg"),
                new clsActor(17, "Robert", "Downey", "robert_downey.jpg"),
                new clsActor(18, "Russell", "Crowe", "russell_crowe.jpg"),
                new clsActor(19, "Ryan", "Gosling", "ryan_gosling.jpg"),
                new clsActor(20, "Tom", "Cruise", "tom_cruise.jpg"),
                new clsActor(21, "Tom", "Hanks", "tom_hanks.jpg"),
                new clsActor(22, "Tom", "Holland", "tom_holland.jpg")
            };
            return listadoActores;
        }
        
        /// <summary>
        /// Devuelve un solo actor con el id que se especifica.
        /// </summary>
        /// <param name="idActor">El id del actor a devolver</param>
        /// <returns>El actor buscado</returns>
        public static clsActor getActorPorId(int idActor)
        {
            List<clsActor> listadoActores = getListadoCompletoActores();
            clsActor actor = new clsActor();
            bool encontrado = false;
            int count = 0;
            while (!encontrado && count < listadoActores.Count)
            {
                if (listadoActores[count].Id == idActor)
                {
                    encontrado = true;
                    actor = listadoActores[count];
                }
                count++;
            }
            if (!encontrado)
            {
                actor = new clsActor();
            }
            return actor;
        }
    }
}