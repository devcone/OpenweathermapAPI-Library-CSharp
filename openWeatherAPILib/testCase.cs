using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openWeatherAPILib
{
    class testCase
    {
        readonly openWeatherAPILib.dataStore weatherData = openWeatherAPILib.main.startRequest("", "");
        string hello = weatherData.currentTemperature.ToString();
   
    }
}
