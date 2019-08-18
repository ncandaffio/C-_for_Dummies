using System;

namespace UsingBinding
{
    public partial class Test1 : System.Web.UI.Page
    {
        protected Show show;

        protected void Page_Load(object sender, 
            EventArgs e)
        {
            show = new Show { ID = 1, Channel = 5,
                EpisodeTitle = "ASP.NET Databinding",
                ScheduledTime = 
                new DateTime(2017, 9, 12, 12, 0, 0),
                ShowTitle = "The C# Show" };
            Page.DataBind();
        }
    }
}