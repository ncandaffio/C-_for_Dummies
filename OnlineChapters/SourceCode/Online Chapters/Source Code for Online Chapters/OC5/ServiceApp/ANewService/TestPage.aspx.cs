using System;

namespace ANewService
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Invoke_Click(object sender, EventArgs e)
        {
            // Create the client.
            UseTheService.TheServiceSoapClient Client = 
                new UseTheService.TheServiceSoapClient();

            // Use the client to invoke the web service.
            Result.Text = Client.DoAdd(
                Int32.Parse(Value1.Text), 
                Int32.Parse(Value2.Text)).ToString();
        }
    }
}