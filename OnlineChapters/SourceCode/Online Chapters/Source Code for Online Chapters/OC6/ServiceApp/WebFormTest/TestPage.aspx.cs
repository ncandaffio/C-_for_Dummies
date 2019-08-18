using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTest
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Invoke_Click(object sender, EventArgs e)
        {
            // Create the client.
            UseTheService.TheServiceClient Client =
                new UseTheService.TheServiceClient();

            // Use the client to invoke the web service.
            Result.Text = Client.DoAdd(
                Int32.Parse(Value1.Text),
                Int32.Parse(Value2.Text)).ToString();

        }

        protected void InvokeContract_Click(object sender, EventArgs e)
        {
            // Create the client.
            UseTheService.TheServiceClient Client =
                new UseTheService.TheServiceClient();

            // Obtain the input data.
            UseTheService.InputType inData = 
                new UseTheService.InputType();
            inData.Value1Value = Int32.Parse(Value1.Text);
            inData.Value2Value = Int32.Parse(Value2.Text);

            // Use the client to invoke the web service.
            UseTheService.ResultType outData = 
                Client.DoAddUsingDataContract(inData);

            // Display the data on screen.
            Result.Text = outData.ResultValue.ToString();
        }
    }
}