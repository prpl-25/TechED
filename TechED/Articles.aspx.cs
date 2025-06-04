using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace TechEd
{
    public partial class Articles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void fetchArticles_Click(object sender, EventArgs e)
        {
            //httpwebrequest to the news focus service that makes a API call to get the articles
            string outputString = "Articles: ";
            string url = "http://webstrar47.fulton.asu.edu/page2/Service.svc/GetNews";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new System.IO.StreamReader(response.GetResponseStream());
            string data = sr.ReadToEnd();
            sr.Close();
            //format and display the articles from the result of the API call
            XmlSerializer serializer = new XmlSerializer(typeof(ArrayOfArticle));
            StringReader stringReader = new StringReader(data);
            ArrayOfArticle articlesList = (ArrayOfArticle)serializer.Deserialize(stringReader);

            foreach(Article article in articlesList.Articles)
            {
                outputString += $"<a href='{article.Url}'>{article.Title}</a><br>";
            }
            //display the articles in the output literal
            outputLiteral.Text = outputString;

        }
    }

    //classes to deserialize the xml response from the API
    [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/NewsAPI.Models")]
    public class Source
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
    }

    [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/NewsAPI.Models")]
    public class Article
    {
        [XmlElement(ElementName = "Author")]
        public string Author { get; set; }
        [XmlElement(ElementName = "Content")]
        public string Content { get; set; }
        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "PublishedAt")]
        public string PublishedAt { get; set; }
        [XmlElement(ElementName = "Source")]
        public Source Source { get; set; }
        [XmlElement(ElementName = "Title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "Url")]
        public string Url { get; set; }
        [XmlElement(ElementName = "UrlToImage")]
        public string UrlToImage { get; set; }
    }

    [XmlRoot(ElementName = "ArrayOfArticle", Namespace = "http://schemas.datacontract.org/2004/07/NewsAPI.Models")]
    [XmlType(Namespace = "http://schemas.datacontract.org/2004/07/NewsAPI.Models")]
    public class ArrayOfArticle
    {
        [XmlElement(ElementName ="Article")]
        public List<Article> Articles { get; set; }
    }
}