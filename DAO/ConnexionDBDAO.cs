using System.Data.SqlClient;

namespace DAO
{
    /// <summary>
    /// Permet une connexion au serveur via la valeur encapsulée dans les paramètres du projet
    /// </summary>
    public static class ConnexionDBDAO
    {
        private static string connexionString = Properties.Settings.Default.InfoConnexion;

        /// <summary>
        /// La méthode static qui renvoie, une connexion à la base de données
        /// </summary>
        /// <returns>La connexion à la base de données</returns>
        public static SqlConnection GetConnexion()
        {
            SqlConnection connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;

            return connexion;
        }
    }
}
