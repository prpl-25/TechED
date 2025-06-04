using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Xml.Linq;
using System.IO;
using Hashing;
namespace TechEd
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //generate a captcha when the page loads
                GenerateCaptcha();
            }
        }

        protected void register_Click(object sender, EventArgs e)
        {
            //check if the captcha is correct
            if(enteredCaptcha.Text == Session["captcha"].ToString())
            {
                //if captcha correct, hash the password and add the member
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string passwordHashed = Class1.HashPassword(password);
                message.Text = "Captcha is correct";
                SubscribeMemeber(username, passwordHashed);
            }
            else
            {
               message.Text ="Captcha is incorrect";
            }
        }

        private void GenerateCaptcha()
        {
            //make a random captcha using characters
            string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random rand = new Random();
            string captcha = string.Empty;
            for (int i = 0; i < 6; i++)
            {
                captcha += chars[rand.Next(0, chars.Length)];
            }
            Session["captcha"] = captcha;
            generatedCaptcha.Text = captcha;
        }

        private void SubscribeMemeber(string username, string password)
        {
            //if member does not exist in the xml file, add the member
            string path = Server.MapPath("~/App_Data/Members.xml");
            XElement member = new XElement("Member",
                new XElement("Username", username),
                new XElement("Password", password)
            );

            if(File.Exists(path))
            {
                XDocument doc = XDocument.Load(path);
                doc.Element("Members").Add(member);
                doc.Save(path);
            }
            else
            {
                XDocument doc = new XDocument(
                    new XElement("Members", member)
                );
                doc.Save(path);
            }
            //redirect to the member only page
            Response.Redirect("~/MemberOnly.aspx");
        }
    }
}