using System;
using System.Web;
using System.Web.UI.WebControls;

namespace PerformRequest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Reference the parent node to keep the object model happy.
            string baseNode = SiteMap.CurrentNode.Title;

            // Check to make sure there are subpages.
            if (SiteMap.CurrentNode.HasChildNodes)
            {
                foreach (SiteMapNode sitemapKids in
                    SiteMap.CurrentNode.ChildNodes)
                {
                    // Put the node name in the listbox.
                    ListBox1.Items.Add(new ListItem(sitemapKids.Title));
                }
            }
        }
    }
}