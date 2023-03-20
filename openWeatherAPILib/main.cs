using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace openWeatherAPILib
{
    public class main
    {
        public static string startRequest(string apiKey, string locationName)
        {
            // Building the query URL and obtaining the SQL document from the API
            string queryURL = getXML.buildRequest(apiKey, locationName);
            XmlDocument weatherDataXML = getXML.requestXMLDoc(queryURL);

            return queryURL;
        }



    }
}
