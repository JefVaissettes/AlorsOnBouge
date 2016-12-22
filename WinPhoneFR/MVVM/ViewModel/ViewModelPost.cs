using ConsumeWSR;
using MetiersPortable;
using System;

namespace WinPhoneFR
{
    public class ViewModelPost : ViewModelBase
    {
        private ConsumeWSRest _cdDAL;
        private int _idPost;
        private string _postContent;
        private DateTime _date;
        private string _auteur;


        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        internal ViewModelPost() { }

        /// <summary>
        /// Constructeur avec passage des paramètres Id, Contenu, Date et Auteur des posts
        /// </summary>
        /// <param name="post"></param>
        /// <param name="cdDAL"></param>
        internal ViewModelPost(Post post, ConsumeWSRest cdDAL)
        {
            _cdDAL = cdDAL;
            _idPost = post.Id;
            _postContent = post.PostContent;
            _date = post.Date;
            _auteur = post.Auteur;
        }

        #endregion Constructeurs


        #region Propriétés bindables

        public int idPost
        {
            get { return _idPost; }
            private set
            {
                if (_idPost != value)
                {
                    _idPost = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string PostContent
        {
            get { return _postContent; }
            private set
            {
                if (_postContent != value)
                {
                    _postContent = value;
                    RaisePropertyChanged();
                }
            }
        }

        public DateTime Date
        {
            get { return _date; }
            private set
            {
                if (_date != value)
                {
                    _date = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Auteur
        {
            get { return _auteur; }
            private set
            {
                if (_auteur != value)
                {
                    _auteur = value;
                    RaisePropertyChanged();
                }
            }
        }

        #endregion Propriétés bindables


        #region Méthodes

        public override string ToString()
        {
            return PostContent;
        }
        #endregion Méthodes

    }
}
