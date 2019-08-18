using System;
using System.Net;
using System.IO;

namespace WebFormTest
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Invoke_Click(object sender, EventArgs e)
        {
            // Create the request URL.
            string url = "http://localhost:49340/api/values/" +
                Value1.Text + "&" + Value2.Text;

            // Define the request object.
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

            // Make the request.
            string output = "0";
            using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
            using (Stream stream = resp.GetResponseStream())
            using (StreamReader read = new StreamReader(stream))
            {
                output = read.ReadToEnd();
            }

            // Display the result on screen.
            Result.Text = output;
        }
    }
}