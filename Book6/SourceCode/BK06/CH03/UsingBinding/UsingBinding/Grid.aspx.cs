using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingBinding
{
    public partial class Grid : System.Web.UI.Page
    {
        protected List<Show> shows = new List<Show>();

        protected void Page_Load(object sender, EventArgs e)
        {
            shows.Add(new Show { ID = 1, Channel = 5,
                EpisodeTitle = "ASP.NET Databinding", ScheduledTime = 
                new DateTime(2017, 9, 12, 12, 0, 0),
                ShowTitle = "The C# Show" });
            shows.Add(new Show { ID = 2, Channel = 5,
                EpisodeTitle = "ASP.NET Styling", ScheduledTime = 
                new DateTime(2017, 9, 12, 13, 0, 0),
                ShowTitle = "The C# Show" });
            shows.Add(new Show { ID = 3, Channel = 8,
                EpisodeTitle = "Inheritance", ScheduledTime = 
                new DateTime(2017, 9, 16, 9, 0, 0),
                ShowTitle = "Learning C#" });
            shows.Add(new Show { ID = 4, Channel = 8,
                EpisodeTitle = "Partial Classes", ScheduledTime = 
                new DateTime(2017, 9, 17, 9, 0, 0),
                ShowTitle = "Learning C#" });
            shows.Add(new Show { ID = 5, Channel = 8,
                EpisodeTitle = "Operator Overloading", ScheduledTime = 
                new DateTime(2017, 9, 18, 9, 0, 0),
                ShowTitle = "Learning C#" });

            GridView1.DataSource = shows;

            // Uncomment to show just two columns.
            /*
            GridView1.AutoGenerateColumns = false;

            BoundField channelColumn = new BoundField();
            channelColumn.DataField = "Channel";
            channelColumn.HeaderText = "Channel";
            GridView1.Columns.Add(channelColumn);

            BoundField episodeColumn = new BoundField();
            episodeColumn.DataField = "EpisodeTitle";
            episodeColumn.HeaderText = "Episode";
            GridView1.Columns.Add(episodeColumn);
            */

            Page.DataBind();
        }
    }
}