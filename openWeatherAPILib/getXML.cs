using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace openWeatherAPILib
{
    class getXML
    {
        public static string buildRequest(string apiKey, string locationName)
        {
            string queryURL = "http://api.openweathermap.org/data/2.5/weather?q="
            + locationName + "&mode=xml&units=metric&APPID=" + apiKey;

            return queryURL;
        }

        public static XmlDocument requestXMLDoc(string queryURL)
        {
            using (WebClient client = new WebClient())
            {
                string xmlContent = client.DownloadString(queryURL);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(xmlContent);
                return xmlDocument;
            }


        }

        public static List<string> getDataFromXML(XmlDocument weatherXML)
        {

        }
    }
}
