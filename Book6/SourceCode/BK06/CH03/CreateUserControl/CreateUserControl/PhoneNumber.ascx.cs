using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreateUserControl
{
    public partial class PhoneNumber : System.Web.UI.UserControl
    {
        private string _phoneNumber;
        public string PhoneNumberValue
        {
            get
            {
                _phoneNumber = string.Format("({0}){1}-{2}", 
                    TextBox1.Text, TextBox2.Text, TextBox3.Text);
                return _phoneNumber;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}