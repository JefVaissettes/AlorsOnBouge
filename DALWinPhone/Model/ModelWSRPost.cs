using ClassesMetiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelWinPhone
{
    [Serializable]

    [DataContract]

    public class ModelWSRPost
    {
        #region Propriétés et attibuts

        /// <summary>
        /// L'identifiant de la reponse
        /// </summary>
        private int _Id;
        [DataMember]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /// <summary>
        /// Le texte de la reponse
        /// </summary>
        private string _PostContent;
        [DataMember]
        public string PostContent
        {
            get { return _PostContent; }
            set { _PostContent = value; }
        }

        /// <summary>
        ///Le sujet auquel appartient la reponse
        /// </summary>
        private Subject _Sujet;
        [DataMember]
        public Subject Sujet
        {
            get { return _Sujet; }
            set { _Sujet = value; }
        }

        /// <summary>
        /// La date de creation de la reponse
        /// </summary>
        private DateTime _Date;
        [DataMember]
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        /// <summary>
        /// L'utilisateur qui a crée et posté la reponse
        /// </summary>
        private Utilisateur _Utilisateur;
        [DataMember]
        public Utilisateur Utilisateur
        {
            get { return _Utilisateur; }
            set { _Utilisateur = value; }
        }

        /// <summary>
        /// L'auteur de la reponse
        /// </summary>
        private string _Auteur;
        [DataMember]
        public string Auteur
        {
            get { return _Auteur; }
            set { _Auteur = value; }
        }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ModelWSRPost() { }

        /// <summary>
        /// Constructeur de la reponse
        /// </summary>
        /// <param name="id">L'identifiant de la reponse</param>
        /// <param name="texte">Le texte de la reponse</param>
        /// <param name="date">La date de création </param>
        /// <param name="utilisateur">L'utilisateur qui a crée et posté la reponse</param>
        /// <param name="sujet">Le sujet auquel appartient la reponse</param>
        public ModelWSRPost(int id, string texte, DateTime date, Subject sujet, Utilisateur utilisateur)
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
        public ModelWSRPost(int id, string text)
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
