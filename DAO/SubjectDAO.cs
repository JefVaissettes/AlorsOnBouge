using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class SubjectDAO
    {
        #region "Property et attributs"

        private static SqlConnection con = ConnexionDBDAO.GetConnexion();

        #endregion

        #region "Methodes"
        /// <summary>
        /// La méthode GetAllSujet, retourne tous les sujets du forum
        /// </summary>
        /// <returns>Tous les sujets</returns>
        public static DataTable GetAllSujets()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllSujets";
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable("TousLesSujet");
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// La methode GetSujetsByCategorie, permet de récupéré tous les sujets d'une catégorie
        /// </summary>
        /// <param name="id_rubric">L'identifiant de la catégorie</param>
        /// <returns>La liste des sujets pour une catégorie donnée</returns>

        public static DataTable GetSujetsByCategorieID(int idrubric)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetSujetsByCategorieID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdRubric";
            parm.Value = idrubric;
            cmd.Parameters.Add(parm);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("TousLesSujets");
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// La Méthode GetSujetByID, permet de retourné un sujet dont l'identifiant est passé en parametre
        /// </summary>
        /// <param name="id_subject">L'identifiant du sujet</param>
        /// <returns>Le sujet, dont l'identifiant est passé en paramatre </returns>
        public static DataTable GetSujetByID(int idsubject)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetSujetByID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@ID_SUBJECT";
            parm.Value = idsubject;
            cmd.Parameters.Add(parm);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("SUBJECT");
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }

        }

        /// <summary>
        /// La méthode AddSujet, permet l'ajout d'un nouveau sujet à la table sujet 
        /// dans la base de données
        /// </summary>
        /// <param name="idCategorie">L'identifiant de la catégorie</param>
        /// <param name="idUtilisateur">L'identifiant de l'utilisateur</param>
        /// <param name="description">La description du sujet</param>
        /// <param name="titre">Le titre su sujet</param>
        /// <returns>Le nombre de ligne, nbligne = 1, si tout se passe bien</returns>
        public static int AddSujet(int idUtilisateur, int idRubric, string titre, string description)
        { 
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "AddSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdUtilisateur = cmd.CreateParameter();
            parmIdUtilisateur.ParameterName = "@ID_UTILISATEUR";
            parmIdUtilisateur.Value = idUtilisateur;
            cmd.Parameters.Add(parmIdUtilisateur);

            SqlParameter parmIdCategorie = cmd.CreateParameter();
            parmIdCategorie.ParameterName = "@ID_RUBRIC";
            parmIdCategorie.Value = idRubric;
            cmd.Parameters.Add(parmIdCategorie);

            SqlParameter parmTitre = cmd.CreateParameter();
            parmTitre.ParameterName = "@SUBJECT_TITLE";
            parmTitre.Value = titre;
            cmd.Parameters.Add(parmTitre);

            SqlParameter parmDescri = cmd.CreateParameter();
            parmDescri.ParameterName = "@SUBJECT_DESCRIPTION";
            parmDescri.Value = description;
            cmd.Parameters.Add(parmDescri);

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

        /// <summary>
        /// La méthode ModifierSujet, permet la modification d'un sujet en lui changeant le titre et/ou la description
        /// on passe les anciennes données en paramètres
        /// </summary>
        /// <param name="subject">le sujet à modifier</param>
        /// <param name="newTitre">le nouveau titre</param>
        /// <param name="newDescription">la nouvelle description</param>
        /// <returns>le nombre de ligne modifié, nbligne = 1 si tout va bien</returns>
        public static int ModifierSujet(int idsubject, string oldTitre, string newTitre, string oldDescription, string newDescription)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "ModifierSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdSubject = cmd.CreateParameter();
            parmIdSubject.ParameterName = "@ID_SUBJECT";
            parmIdSubject.Value = idsubject;
            cmd.Parameters.Add(parmIdSubject);

            SqlParameter parmNewTitre = cmd.CreateParameter();
            parmNewTitre.ParameterName = "@NEW_TITRE";
            parmNewTitre.Value = newTitre;
            cmd.Parameters.Add(parmNewTitre);

            SqlParameter parmOldTitre = cmd.CreateParameter();
            parmOldTitre.ParameterName = "@OLD_TITRE";
            parmOldTitre.Value = oldTitre;
            cmd.Parameters.Add(parmOldTitre);

            SqlParameter parmNewDescr = cmd.CreateParameter();
            parmNewDescr.ParameterName = "@NEW_DESC";
            parmNewDescr.Value = newDescription;
            cmd.Parameters.Add(parmNewDescr);

            SqlParameter parmOldDescr = cmd.CreateParameter();
            parmOldDescr.ParameterName = "@OLD_DESC";
            parmOldDescr.Value = oldDescription;
            cmd.Parameters.Add(parmOldDescr);

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

        /// <summary>
        /// La méthode DeleteSujet, permet la suppression d'un sujet
        /// dont l'id est passé en parametre
        /// </summary>
        /// <param name="id_subject">L'identifiant du sujet</param>
        /// <returns>Le nombre de lignes supprimées, nbligne = 1 si tout va bien</returns>
        public static int DeleteSujet(int idSubject)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DeleteSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdSubject = cmd.CreateParameter();
            parmIdSubject.ParameterName = "@ID_SUBJECT";
            parmIdSubject.Value = idSubject;
            cmd.Parameters.Add(parmIdSubject);

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
