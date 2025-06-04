using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechEd
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //checks if the user is already logged in using cookies and if so redirect to the default page
            if (Request.Cookies["UserLogin"] != null)
            {
                string username = Request.Cookies["UserLogin"]["Username"];
                if(!string.IsNullOrEmpty(username))
                {
                    Session["LoggedIn"] = true;
                    Response.Redirect("~/Default.aspx");
                }
                Response.Redirect("~/Default.aspx");
            }
            else if(Session["LoggedIn"] != null && (bool)Session["LoggedIn"])
            {
                Response.Redirect("~/Default.aspx");
            }
            
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //creating a cookie
            HttpCookie cookie = new HttpCookie("UserLogin");
            //storing the username in the cookie
            cookie["Username"] = txtUsername.Text;
            cookie.Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies.Add(cookie);
            //redirecting the user after they've logged in
            Session["LoggedIn"] = true;
            Response.Redirect("~/Default.aspx");
          
        }
    }
}