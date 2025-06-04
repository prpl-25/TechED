using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace TechEd
{
    public partial class MemberOnly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
        protected void changePass_Click(object sender, EventArgs e)
        {
            //check if the passwords are same
            if (txtNewPass.Text == txtConfirmPass.Text)
            {
                //get the username from the cookie
                string username = usernametxt.Text;
                //get the path of the xml file
                string path = Server.MapPath("~/App_Data/Members.xml");
                XDocument doc = XDocument.Load(path);
                //get the member record
                var member = doc.Root.Elements("Member").FirstOrDefault(x => x.Element("Username").Value == username);
                //update the password
                member.Element("Password").Value = newPass.Text;
                doc.Save(path);
                Response.Write("Password changed successfully");
            }
            else
            {
                Response.Write("Passwords do not match");
            }
        }
    }
}