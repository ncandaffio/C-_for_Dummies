using System;
using System.Web.UI;
using System.Diagnostics;

namespace PerformRequest
{
    public partial class TestRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page.IsPostBack))
            {
                foreach (String requestInfo in Request.Form)
                {
                    Debug.WriteLine(requestInfo);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (String requestInfo in Request.Form)
            {
                Debug.WriteLine(requestInfo);
            }
        }
    }
}