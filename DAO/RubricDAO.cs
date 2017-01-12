using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    /// <summary>
    /// RubricDAO, permet de procéder à des actions sur la table Rubric du SGBD
    /// </summary>
    /// 
    public static class RubricDAO

    {
        #region "Property et attributs"

        private static SqlConnection con = ConnexionDBDAO.GetConnexion();

        #endregion

        #region "Methodes"

        /// <summary>
        /// La méthodes GetAllCategories, permet de récupérer toutes les catégories
        /// enregistrées dans la base de données
        /// </summary>
        /// <returns>Les rubriques de la database</returns>

        public static DataTable GetAllRubrics()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllCategories";
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Rubric");
                da.Fill(dt);

                return dt;
            }
            catch (System.Exception)
            {

                return null;
            }
        }

        /// <summary>
        /// La méthode GetRubricById, permet de récuperer une catégorie 
        /// dont le l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="idRubric">L'identifiant de la catégorie</param>
        /// <returns>La Rubric</returns>

        public static DataTable GetRubricByID(int idRubric)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetCategorieByID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdRubric";
            parm.Value = idRubric;
            cmd.Parameters.Add(parm);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Rubric");
                da.Fill(dt);

                return dt;
            }
            catch (System.Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
