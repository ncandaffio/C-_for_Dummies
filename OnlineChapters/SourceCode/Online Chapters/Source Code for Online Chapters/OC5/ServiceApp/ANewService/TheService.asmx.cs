using System.Web.Services;

namespace ANewService
{
    /// <summary>
    /// Summary description for TheService
    /// </summary>
    [WebService(Namespace = "http://www.mysite.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TheService : System.Web.Services.WebService
    {

        [WebMethod]
        public int DoAdd(int Value1, int Value2)
        {
            return Value1 + Value2;
        }
    }
}
