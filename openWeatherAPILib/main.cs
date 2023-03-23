using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace openWeatherAPILib
{
    public partial class main
    {

        public static dataStore startRequest(string apiKey, string locationName)
        {
            // Building the query URL and obtaining the SQL document from the API
            string queryURL = getXML.buildRequest(apiKey, locationName);
            XmlDocument weatherDataXML = getXML.requestXMLDoc(queryURL);

            // Filtering the data from the XML file
            List<string> weatherData = getXML.getDataFromXML(weatherDataXML);

            // store the data
            List<dataStore> weatherDataList = new List<dataStore>();
            dataStore newWeatherForecast = new dataStore("hello", "yourmum");

            weatherDataList.Add(newWeatherForecast);

            return newWeatherForecast;

        }
    }
}
