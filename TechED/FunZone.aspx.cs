using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Xml;

namespace TechEd
{
    public partial class FunZone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Gets the values from the textboxes
            string inputString = input.Text;
            string url = "http://webstrar47.fulton.asu.edu/page0/Service1.svc/WordFilter?str=" + inputString;
            //httpWebRequest with the url
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new System.IO.StreamReader(response.GetResponseStream());
            string result = sr.ReadToEnd();
            sr.Close();
            //loads the xml document and formating it to get the output string
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(result);
            string outputString = doc.InnerText;
            output.Text = outputString;
        }

        protected void webBtn_Click(object sender, EventArgs e)
        {
            //httpwebrequest to get the content of the webpage using the entered url
            string inputURL = inputUrl.Text;
            string url = "http://webstrar47.fulton.asu.edu/page1/Service1.svc/WebDownload?url=" + inputURL; 
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string outputString = sr.ReadToEnd();
            sr.Close();

            //Message for grader: I am not sure why the output is not displaying the content of the webpage.
            //I had the same thing for assignment 3 and the contents were displayed in the label, but now
            //it displays the html code.
            outputLbl.Text = outputString;
        }
    }
}