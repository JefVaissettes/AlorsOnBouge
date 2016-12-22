using System.Runtime.Serialization;

namespace MetiersPortable
{
    [DataContract]
    public class Utilisateur
    {
        #region "Property et attributs"

        [DataMember]
        private int _Id;
        /// <summary>
        /// Identifiant de l'utilisateur
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        [DataMember]
        private string _Username;
        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        [DataMember]
        private string _Mdp;
        /// <summary>
        /// Mot de passe de l'utilisateur
        /// </summary>
        public string Mdp
        {
            get { return _Mdp; }
            set { _Mdp = value; }
        }

        [DataMember]
        private string _Email;
        /// <summary>
        /// Email de l'utilisateur
        /// </summary>
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        [DataMember]
        private bool _IsRmod;
        /// <summary>
        /// Numéro de role de l'utilisateur
        /// Isrmod permet de voir si l'user est un moderateur ou non 
        /// </summary>
        public bool IsRmod
        {
            get { return _IsRmod; }
            set { _IsRmod = value; }
        }
        #endregion

        #region "Constructeurs"

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Utilisateur() { }

        /// <summary>
        /// Constructeur d'un utilisateur
        /// </summary>
        /// <param name="id">Identifiant d'un utilisateur</param>
        /// <param name="username">Nom d'un utilisateur</param>
        /// <param name="password">Mot de passe d'un utilisateur</param>
        /// <param name="email">Email d'un utilisateur</param>
        /// <param name="role">Role d'un utilisateur</param>
        public Utilisateur(int id, string username, string password, string email, bool isRmod)
        {
            this.Id = id;
            this.Username = username;
            this.Mdp = password;
            this.Email = email;
            this.IsRmod = isRmod;
        }

        public Utilisateur(int id, string username, string password, bool isRmod)
        {
            this.Id = id;
            this.Username = username;
            this.Mdp = password;
            this.IsRmod = isRmod;
        }
        #endregion
    }
}
