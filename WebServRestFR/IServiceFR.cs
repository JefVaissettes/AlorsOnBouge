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
    [ServiceContract]
    public interface IServiceFR
    {
        [OperationContract]
        [WebGet(UriTemplate = "Rubric")]
        List<Rubric> GetAllCategories();

        [OperationContract]
        [WebGet(UriTemplate = "subject/{idrubric}")]
        List<Subject> GetSujetsByCategorieID(string idrubric);

        [OperationContract]
        [WebGet(UriTemplate = "Post/{id_subject}")]
        List<Post> GetAllReponseBySujet(string id_subject);
    }
}
