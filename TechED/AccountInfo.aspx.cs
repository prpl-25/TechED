using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace TechEd
{
    public partial class AccountInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //check if username in members.xml
            string username = txtUsername.Text;
            //load the xml file that stores the members
            string path = Server.MapPath("~/App_Data/Members.xml");
            XDocument doc = XDocument.Load(path);
            //search for the member with the username
            var member = doc.Root.Elements("Member").FirstOrDefault(x => x.Element("Username").Value == username);
            //if member is found, redirect to member only page
            if (member != null)
            {
                Response.Redirect("~/MemberOnly.aspx");
            }
            else
            {
                Response.Write("You are not a registered member. Please Self register from home page");
            }
        }
    }
}