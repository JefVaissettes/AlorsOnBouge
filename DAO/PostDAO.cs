using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    /// <summary>
    /// PostDAO, permet de récupérer les posts, qui se trouvent dans la base de données
    /// </summary>
    public static class PostDAO
    {
        #region "Property et attributs"

        private static SqlConnection con = ConnexionDBDAO.GetConnexion();

        #endregion

        #region "Constructeurs"
        #endregion

        #region "Methodes"

        /// <summary>
        /// La méthodes GetAllReponseBySujet, permet de recupérer toutes les reponses
        /// d'un sujet dont l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="id_subject">L'identifiant du sujet</param>
        /// <returns>Les reponses, concernant un sujet dont l'identifiant est passé en paramètre</returns>
        /// 
        public static DataTable GetAllReponseBySujet(int id_subject)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllReponseBySujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@idSubject";
            parm.Value = id_subject;
            cmd.Parameters.Add(parm);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Post");
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// La méthode AddReponse, permet d'ajouter une reponse au sujet passé en paramateur
        /// par un utilisateur connecté
        /// </summary>
        /// <param name="id_subject">L'identifiant du sujet concerné</param>
        /// <param name="id_users">L'identifiant de l'utilisateur, qui répond</param>
        /// <param name="post_content">Le texte de la reponse</param>
        /// <returns></returns>
        public static int AddReponse(int idUsers, int idSubject, string texte)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "AddReponse";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmididUsers = cmd.CreateParameter();
            parmididUsers.ParameterName = "@ID_UTILISATEUR";
            parmididUsers.Value = idUsers;
            cmd.Parameters.Add(parmididUsers);

            SqlParameter parmidSubject = cmd.CreateParameter();
            parmidSubject.ParameterName = "@ID_SUBJECT";
            parmidSubject.Value = idSubject;
            cmd.Parameters.Add(parmidSubject);

      
            SqlParameter parmTexte = cmd.CreateParameter();
            parmTexte.ParameterName = "@POST_CONTENT";
            parmTexte.Value = texte;
            cmd.Parameters.Add(parmTexte);

            try
            {
                con.Open();
                //excute une action T-SQL sur la connexion et retourne le nombres de lignes affectéess
                int nbLigne = cmd.ExecuteNonQuery();
                con.Close();
                return nbLigne;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// La méthode DeleteReponse, permet la suppression d'une reponse
        /// dont l'id est passé en parametre
        /// </summary>
        /// <param name="idPost">L'identifiant de la reponse</param>
        /// <returns>Le nombre de lignes supprimées, nbligne = 1 si tout va bien</returns>
        public static int DeleteReponse(int idPost)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DeleteReponse";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdPost = cmd.CreateParameter();
            parmIdPost.ParameterName = "@ID_POST";
            parmIdPost.Value = idPost;
            cmd.Parameters.Add(parmIdPost);

            try
            {
                con.Open();
                int nbLigne = cmd.ExecuteNonQuery();
                con.Close();
                return nbLigne;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        #endregion
    }
}
