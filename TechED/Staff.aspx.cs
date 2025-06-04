using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace TechEd
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            //check if the staff is valid
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if(checkStaff(username,password))
            {
                //if staff is valid, set the session variable and redirect to staff management page
                Session["authenticated"] = true;
                Response.Redirect("StaffManagement.aspx");
            }
            else
            {
                response.Text = "Invalid username or password";
            }
        }

        private bool checkStaff(string username, string password)
        {
            //load the xml file that stores the staff
            string path = Server.MapPath("~/App_Data/Staff.xml");
            XDocument doc = XDocument.Load(path);
            //search for the staff with the username and password
            var record = doc.Root.Elements("Staff").FirstOrDefault(x => x.Element("Username").Value == username
            && x.Element("Password").Value == password);
            //if staff is found, return true
            if (record != null)
            {
                return true;
            }
            //if staff is not found, return false
            else
            {
                return false;
            }
        }
    }
}