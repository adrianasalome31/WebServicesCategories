using System.Web.Services;
using System.Data;
using System.Xml.Serialization;

namespace WebServicesCategories
{
    /// <summary>
    /// Descripción breve de ServicesCategories
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicesCategories : System.Web.Services.WebService
    {

        
        DataCategoriesModel dataEmployess = new DataCategoriesModel();
        [WebMethod]
        public DataSet getCategories()
        {
            return dataEmployess.getCategories();
        }
    }
}
