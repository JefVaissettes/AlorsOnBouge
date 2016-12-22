using System.Collections.Generic;
using BLLFR;
using MetiersPortable;

namespace WebServRestFR
{
    public class ServiceFR : IServiceFR
    {
        public List<Rubric> GetAllCategories()
        {
            return Outil.GetAllRubrics();
        }

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
