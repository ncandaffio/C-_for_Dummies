using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingTextbox
{
    public partial class Textboxes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.MaxLength = 20;
            TextBox1.Height = 22;
            TextBox1.Width = 135;
            TextBox1.Enabled = true;
        }
    }
}