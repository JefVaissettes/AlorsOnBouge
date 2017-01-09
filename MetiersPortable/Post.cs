using System;
using System.Runtime.Serialization;

namespace MetiersPortable
{
    /// <summary>
    /// Un post est défini par son id contenu sujet auquel il appartient, 
    /// </summary>
    [DataContract]
    public class Post
    {
        #region "Property et attributs"

        /// <summary>
        /// L'identifiant de la reponse
        /// </summary>
        [DataMember]
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /// <summary>
        /// Le texte de la reponse
        /// </summary>
        [DataMember]
        private string _PostContent;
        public string PostContent
        {
            get { return _PostContent; }
            set { _PostContent = value; }
        }

        /// <summary>
        ///Le sujet auquel appartient la reponse
        /// </summary>
        [DataMember]
        private Subject _Sujet;
        public Subject Sujet
        {
            get { return _Sujet; }
            set { _Sujet = value; }
        }

        /// <summary>
        /// La date de creation de la reponse
        /// </summary>
        [DataMember]
        private DateTime _Date;
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        /// <summary>
        /// L'utilisateur qui a crée et posté la reponse
        /// </summary>

        [DataMember]
        private Utilisateur _Utilisateur;
        public Utilisateur Utilisateur
        {
            get { return _Utilisateur; }
            set { _Utilisateur = value; }
        }

        /// <summary>
        /// L'auteur de la reponse
        /// </summary>

        [DataMember]
        private string _Auteur;
        public string Auteur
        {
            get { return _Auteur; }
            set { _Auteur = value; }
        }

        #endregion

        #region "Constructeurs"

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Post() { }

        /// <summary>
        /// Constructeur de la reponse
        /// </summary>
        /// <param name="id">L'identifiant de la reponse</param>
        /// <param name="texte">Le texte de la reponse</param>
        /// <param name="date">La date de création </param>
        /// <param name="utilisateur">L'utilisateur qui a crée et posté la reponse</param>
        /// <param name="sujet">Le sujet auquel appartient la reponse</param>
        public Post(int id, string texte, DateTime date, Subject sujet, Utilisateur utilisateur)
        {
            this.Id = id;
            this.PostContent = texte;
            this.Date = date;
            this.Auteur = utilisateur.Username;
            this.Sujet = sujet;
            this.Utilisateur = utilisateur;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        public Post(int id, string text)
        {
            this.Id = id;
            this.PostContent = text;
        }

        #endregion

        #region "Methodes"

        /// <summary>
        /// La méthode permet de reccupèré le nom de l'utilisateur 
        /// </summary>
        /// <returns>Username (nom de l'utilisateur)</returns>
        public string GetUsername()
        {
            return Utilisateur.Username;
        }
        #endregion
    }
}
