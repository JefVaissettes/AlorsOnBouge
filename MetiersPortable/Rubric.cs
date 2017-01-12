using System.Runtime.Serialization;

namespace MetiersPortable
{
    /// <summary>
    /// Rubric défini par son ID, et son titre
    /// </summary>
    [DataContract]
    public class Rubric

    {
        #region "Property et attributs"

        [DataMember]
        private int _Id;
        /// <summary>
        /// Identifiant de la rubrique
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        [DataMember]
        private string _Libelle;
        /// <summary>
        /// Titre de la rubrique
        /// </summary>
        public string Libelle
        {
            get { return _Libelle; }
            set { _Libelle = value; }
        }
        #endregion

        #region "Constructeurs"

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Rubric() { }

        /// <summary>
        /// Constructeur d'une rubrique
        /// </summary>
        /// <param name="id">L'identifiant d'une rubrique</param>
        /// <param name="title">Titre d'une rubrique</param>
        /// 
        public Rubric(int id, string title)
        {
            this.Id = id;
            this.Libelle = title;
        }
        #endregion       
    }
}
