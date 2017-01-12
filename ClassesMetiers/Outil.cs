using DAO;
using MetiersPortable;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLLFR
{
    /// <summary>
    /// Cette classe utilise les méthodes des classes DAO
    /// </summary>
    public class Outil
    {
        #region Rubrique

        /// <summary>
        /// Méthode retournant la liste des rubriques
        /// </summary>
        /// <returns>Liste des rubriques du forum</returns>
        public static List<Rubric> GetAllRubrics()
        {
            DataTable dt = RubricDAO.GetAllRubrics();
                if (dt.Rows.Count >= 1)
            {
                List<Rubric> _Rubrics = new List<Rubric>();
                foreach (DataRow row in dt.Rows)
                {
                    Rubric cat = new Rubric(int.Parse(row["ID_RUBRIC"].ToString()), row["RUBRIC_TITLE"].ToString());
                    cat.Id = int.Parse(row["ID_RUBRIC"].ToString());
                    _Rubrics.Add(cat);
                }
                return _Rubrics;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idRubric"></param>
        /// <returns></returns>
        public static Rubric GetRubricByID(int idRubric)
        {
            DataTable dt = RubricDAO.GetRubricByID(idRubric);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Rubric cat = new Rubric(idRubric, row["RUBRIC_TITLE"].ToString());
                return cat;
            }
            return null;
        }

        #endregion

        #region Sujet

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Subject> GetAllSujets()
        {
            DataTable dt = SubjectDAO.GetAllSujets();

            if (dt.Rows.Count >= 1)
            {
                List<Subject> _Subjects = new List<Subject>();

                foreach (DataRow row in dt.Rows)
                {
                    Subject subject = new Subject(int.Parse(row["ID_SUBJECT"].ToString()), row["SUBJECT_TITLE"].ToString(), row["SUBJECT_DESCRIPTION"].ToString(), DateTime.Parse(row["SUBJECT_DATE"].ToString()), GetUserByID(int.Parse(row["ID_UTILISATEUR"].ToString())), GetRubricByID(int.Parse(row["ID_RUBRIC"].ToString())));
                    _Subjects.Add(subject);
                }

                return _Subjects;
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idrubric"></param>
        /// <returns></returns>
        public static List<Subject> GetSujetsByCategorieID(int idrubric)
        {
            DataTable dt = SubjectDAO.GetSujetsByCategorieID(idrubric);
            if (dt.Rows.Count >= 1)
            {
                List<Subject> _Sujets = new List<Subject>();

                // parcours des toutes lignes de notre table 
                foreach (DataRow row in dt.Rows)
                {
                    
                    Subject subject = new Subject(int.Parse(row["ID_SUBJECT"].ToString()), row["SUBJECT_TITLE"].ToString(), row["SUBJECT_DESCRIPTION"].ToString(), DateTime.Parse(row["SUBJECT_DATE"].ToString()), GetUserByID(int.Parse(row["ID_UTILISATEUR"].ToString())), GetRubricByID(int.Parse(row["ID_RUBRIC"].ToString())));
                    _Sujets.Add(subject);
                }
                return _Sujets;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idsubject"></param>
        /// <returns></returns>
        public static Subject GetSujetByID(int idsubject)
        {
            DataTable dt = SubjectDAO.GetSujetByID(idsubject);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Subject subject = new Subject(int.Parse(row["ID_SUBJECT"].ToString()), row["SUBJECT_TITLE"].ToString(), row["SUBJECT_DESCRIPTION"].ToString(), DateTime.Parse(row["SUBJECT_DATE"].ToString()), GetUserByID(int.Parse(row["ID_UTILISATEUR"].ToString())), GetRubricByID(int.Parse(row["ID_RUBRIC"].ToString())));

                return subject;
            }

            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idRubric"></param>
        /// <param name="description"></param>
        /// <param name="titre"></param>
        /// <returns></returns>
        public static int AddSujet(int idUtilisateur, int idRubric,string titre, string description)
        {
            return SubjectDAO.AddSujet(idUtilisateur, idRubric , titre, description);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idsubject"></param>
        /// <param name="oldTitre"></param>
        /// <param name="newTitre"></param>
        /// <param name="oldDescription"></param>
        /// <param name="newDescription"></param>
        /// <returns></returns>
        public static int ModifierSujet(int idsubject, string oldTitre, string newTitre, string oldDescription, string newDescription)
        {
            return SubjectDAO.ModifierSujet(idsubject, oldTitre, oldDescription, newTitre,  newDescription);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idSubject"></param>
        /// <returns></returns>
        public static int DeleteSujet(int idSubject)
        {
            return SubjectDAO.DeleteSujet(idSubject);
        }

        #endregion

        #region Utilisateur

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Utilisateur GetLoginPassword(string username, string password)
        {
            DataTable dt = UtilisateurDAO.Username(username, password);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                return GetUserByID(int.Parse(row["ID_UTILISATEUR"].ToString()));
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idutilisateur"></param>
        /// <returns></returns>
        public static Utilisateur GetUserByID(int idutilisateur)
        {
            DataTable dt = UtilisateurDAO.GetUserByID(idutilisateur);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];

                Utilisateur user = new Utilisateur(int.Parse(row["ID_UTILISATEUR"].ToString()), row["USERNAME"].ToString(), row["PASSWORD"].ToString(), (bool)row["ROLE"]);

                return user;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Utilisateur> GetAllUsers()
        {
            DataTable dt = UtilisateurDAO.GetAllUtilisateurs();
            if (dt.Rows.Count >= 1)
            {
                List<Utilisateur> _Users = new List<Utilisateur>();
                foreach (DataRow row in dt.Rows)
                {
                    Utilisateur user = new Utilisateur(int.Parse(row["ID_UTILISATEUR"].ToString()), row["USERNAME"].ToString(), row["PASSWORD"].ToString(), (bool)row["ROLE"]);
                    _Users.Add(user);
                }
                return _Users;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iduser"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static int ModifierPassword(int iduser, string password)
        {
            return UtilisateurDAO.ModifierPassword(iduser, password);
        }

        #endregion

        #region Post

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_subject"></param>
        /// <returns></returns>
        public static List<Post> GetAllReponseBySujet(int id_subject)
        {
            DataTable dt = PostDAO.GetAllReponseBySujet(id_subject);
                if (dt.Rows.Count >= 1)
            {
                List<Post> _Posts = new List<Post>();
                foreach (DataRow row in dt.Rows)
                {
                  
                    Post post = new Post(int.Parse(row["ID_POST"].ToString()), row["POST_CONTENT"].ToString(), DateTime.Parse(row["POST_DATE"].ToString()), GetSujetByID(id_subject), GetUserByID(int.Parse(row["ID_UTILISATEUR"].ToString())));
                    _Posts.Add(post);
                }
                return _Posts;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUsers"></param>
        /// <param name="idSubject"></param>
        /// <param name="texte"></param>
        /// <returns></returns>
        public static int AddReponse(int idUsers, int idSubject, string texte)
        {
            return PostDAO.AddReponse(idUsers, idSubject,  texte);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPost"></param>
        /// <returns></returns>
        public static int DeleteReponse(int idPost)
        {
            return PostDAO.DeleteReponse(idPost);
        }
        #endregion
    }
}
