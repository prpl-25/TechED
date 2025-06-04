using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechEd
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //check whether the user is logged in
                if (Session["LoggedIn"] == null)
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
        }
        //methods for staff and member buttons - implemententation not complete (assignment 6)
        protected void memberBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Member.aspx");
        }

        protected void staffBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Staff.aspx");
        }
    }
}