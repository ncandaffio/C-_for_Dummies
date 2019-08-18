using System;

namespace WebControls
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = 
                "This is some text from the codebehind.";
        }
    }
}