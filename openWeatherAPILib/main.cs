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

        public static bool startRequest(string apiKey, string locationName)
        {
            try
            {
                // Building the query URL and obtaining the SQL document from the API
                string queryURL = getXML.buildRequest(apiKey, locationName);
                XmlDocument weatherDataXML = getXML.requestXMLDoc(queryURL);

                // Filtering the data from the XML file
                List<string> weatherData = getXML.getDataFromXML(weatherDataXML);

                // Setting the variables
                string currentTemperature = weatherData[0];
                string feelsLikeTemperature = weatherData[1];
                string humidity = weatherData[2];
                string pressure = weatherData[3];
                string clouds = weatherData[4];
                string visibility = weatherData[5];
                string precipitation = weatherData[6];
                string weather = weatherData[7];

                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
