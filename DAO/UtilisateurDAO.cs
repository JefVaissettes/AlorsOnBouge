using System;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    /// <summary>
    /// UtilisateurDAO, permet de récupérer les catégories, qui se trouvent dans la base de données
    /// </summary>
    public static class UtilisateurDAO
    {
        #region "Property et attributs"

        private static SqlConnection con = ConnexionDBDAO.GetConnexion();

        #endregion

        #region "Methodes"

        /// <summary>
        /// Cette méthode permet à un utilisateur de s'identifier
        /// </summary>
        /// <param name="username">Le username (NOM)</param>
        /// <param name="password">LE mot de passe</param>
        /// <returns></returns>
        public static DataTable Username(string username, string password)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetLoginPassword";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmUsername = cmd.CreateParameter();
            parmUsername.ParameterName = "@USERNAME";
            parmUsername.Value = username;
            cmd.Parameters.Add(parmUsername);

            SqlParameter parmMPD = cmd.CreateParameter();
            parmMPD.ParameterName = "@PASSWORD";
            parmMPD.Value = password;
            cmd.Parameters.Add(parmMPD);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Username");
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DataTable GetUserByID(int idutilisateur)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetUserByID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@iduser";
            parm.Value = idutilisateur;
            cmd.Parameters.Add(parm);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Utilisateur");
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static DataTable GetAllUtilisateurs()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllUtilisateurs";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Users");

            return dt;
        }

        public static int ModifierPassword(int iduser, string password)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "ModifierPassword";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdUser = cmd.CreateParameter(); //On creer une nouvelle instance d'objet sqlParameter
            parIdUser.ParameterName = "@ID_UTILISATEUR";
            parIdUser.Value = iduser;
            cmd.Parameters.Add(parIdUser);

            SqlParameter parPassword = cmd.CreateParameter(); //On creer une nouvelle instance d'objet sqlParameter
            parPassword.ParameterName = "@PASSWORD";
            parPassword.Value = password;
            cmd.Parameters.Add(parPassword);

            try
            {
                con.Open();
                int nbligne = cmd.ExecuteNonQuery();
                con.Close();
                return nbligne;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        #endregion
    }
}
