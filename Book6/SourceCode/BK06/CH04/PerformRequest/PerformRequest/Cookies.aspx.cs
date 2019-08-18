using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PerformRequest
{
    public partial class Cookies : System.Web.UI.Page
    {
        // The user making the request.
        WebUser currentUser = new WebUser();

        // A list of users who are working with the application.
        List<WebUser> usersInDatabase = new List<WebUser>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //This is a first request, so set the cookie
                Guid sessionGuid = new Guid();
                currentUser.SessionId = sessionGuid;

                //Tell the database about the new user
                usersInDatabase.Add(currentUser);

                //Set the cookie
                Response.Cookies.Add(
                    new HttpCookie(
                        "SessionId", sessionGuid.ToString()));
            }
            else
            {
                //The is a postback so we need to get the cookie
                string cookieSession = Request.Cookies.Get(
                    "SessionId").Value.ToString();
                Guid sessionGuid = new Guid(cookieSession);

                // Obtain the user information from the database.
                var returningUser = 
                    from u in usersInDatabase
                    where u.SessionId.ToString() == sessionGuid.ToString()
                    select u;

                foreach (var user in returningUser)
                {
                    //Better only be one
                    currentUser = user;
                }

                // Output the cookie value.
                CookieValue.Text = cookieSession;
            }
        }

        //This class would be in the library somewhere, 
        //not actually in this file.
        public class WebUser
        {
            public Guid SessionId { get; set; }
        }
    }
}