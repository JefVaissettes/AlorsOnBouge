using MetiersPortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServRestFR
{
    /// <summary>
    /// Contrat
    /// .
    /// </summary>
    [ServiceContract]
    public interface IServiceFR
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Liste de rubrique</returns>
        [OperationContract]
        [WebGet(UriTemplate = "Rubric")]
        List<Rubric> GetAllCategories();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idrubric"></param>
        /// <returns>Liste de sujet</returns>
        [OperationContract]
        [WebGet(UriTemplate = "subject/{idrubric}")]
        List<Subject> GetSujetsByCategorieID(string idrubric);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_subject"></param>
        /// <returns>Liste de post</returns>
        [OperationContract]
        [WebGet(UriTemplate = "Post/{id_subject}")]
        List<Post> GetAllReponseBySujet(string id_subject);
    }
}
