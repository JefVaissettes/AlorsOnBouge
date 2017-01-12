using System;
using System.Runtime.Serialization;

namespace MetiersPortable
{
    /// <summary>
    /// Post défini par son ID, contenu, date et auteur
    /// Post fait partie d'un sujet
    /// </summary>
    [DataContract]
    public class Post
    {
        #region "Property et attributs"

        [DataMember]
        private int _Id;
        /// <summary>
        /// L'identifiant de la reponse
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }


        [DataMember]
        private string _PostContent;
        /// <summary>
        /// Le texte de la reponse
        /// </summary>
        public string PostContent
        {
            get { return _PostContent; }
            set { _PostContent = value; }
        }


        [DataMember]
        private Subject _Sujet;
        /// <summary>
        ///Le sujet auquel appartient la reponse
        /// </summary>
        public Subject Sujet
        {
            get { return _Sujet; }
            set { _Sujet = value; }
        }


        [DataMember]
        private DateTime _Date;
        /// <summary>
        /// La date de creation de la reponse
        /// </summary>
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        [DataMember]
        private Utilisateur _Utilisateur;
        /// <summary>
        /// L'utilisateur qui a crée et posté la reponse
        /// </summary>
        public Utilisateur Utilisateur
        {
            get { return _Utilisateur; }
            set { _Utilisateur = value; }
        }

        [DataMember]
        private string _Auteur;
        /// <summary>
        /// L'auteur de la reponse
        /// </summary>
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
        /// Méthode permettant de connaître l'username du redacteur du post
        /// </summary>
        /// <returns>Username</returns>
        public string GetUsername()
        {
            return Utilisateur.Username;
        }
        #endregion
    }
}
