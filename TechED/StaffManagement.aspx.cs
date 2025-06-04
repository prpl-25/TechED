using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace TechEd
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void addBtn_Click(object sender, EventArgs e)
        {
            //add staff member
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            //checking if fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                response.Text = "Username or password cannot be empty!";
                return;
            }
            //load the xml file that stores staff members
            string path = Server.MapPath("~/App_Data/Staff.xml");
            XDocument doc = XDocument.Load(path);
            XElement addRecord = new XElement("Staff",
                new XElement("Username", username),
                new XElement("Password", password));
            doc.Root.Add(addRecord);
            doc.Save(path);

            response.Text = "Staff member added successfully!";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        protected void removeBtn_Click(object sender, EventArgs e)
        {
            //remove staff member
            string username = txtUsernameR.Text;
            if (string.IsNullOrEmpty(username))
            {
                response.Text = "Username cannot be empty!";
                return;
            }
            //load the xml file that stores staff members
            string path = Server.MapPath("~/App_Data/Staff.xml");
            XDocument doc = XDocument.Load(path);
            var removeRecord = doc.Root.Elements("Staff").FirstOrDefault(x => x.Element("Username").Value == username);
            //check if staff member exists
            if (removeRecord != null)
            {
                //remove staff member and save the file
                removeRecord.Remove();
                doc.Save(path);
                response2.Text = "Staff member removed successfully!";
                txtUsernameR.Text = "";
            }
            else
            {
                //staff member not found
                response2.Text = "Staff member not found! Already removed or incorrect username entered! Check username again";
            }
        }
    }
}