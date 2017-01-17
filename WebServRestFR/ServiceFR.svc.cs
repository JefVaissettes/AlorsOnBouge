using System.Collections.Generic;
using BLLFR;
using MetiersPortable;

namespace WebServRestFR
{
    /// <summary>
    /// 
    /// </summary>
    public class ServiceFR : IServiceFR
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Rubric> GetAllCategories()
        {
            return Outil.GetAllRubrics();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_subject"></param>
        /// <returns></returns>
        public List<Post> GetAllReponseBySujet(string id_subject)
        {
            int r; //Variable locale de retour (résultat)
            if(int.TryParse(id_subject, out r))
            {
                return Outil.GetAllReponseBySujet(r);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idrubric"></param>
        /// <returns></returns>
        public List<Subject> GetSujetsByCategorieID(string idrubric)
        {
            int r; //Variable locale de retour (résultat)
            if (int.TryParse(idrubric, out r))
            {
                return Outil.GetSujetsByCategorieID(r);
            }
            else
            {
                return null;
            }
        }
    }
}
