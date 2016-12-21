using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelWinPhone
{
    public static class ModelWSRConnexion
    {
        private static string connexionString = Properties.Settings.Default.InfoConnexion;

        public static SqlConnection GetConnexion()
        {
            SqlConnection connexion = new SqlConnection();
            connexion.ConnectionString = connexionString;

            return connexion;
        }
    }
}
