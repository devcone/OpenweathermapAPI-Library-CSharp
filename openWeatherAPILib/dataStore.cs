using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openWeatherAPILib
{
    public class dataStore
    {
        // Setting the variables
        public string currentTemperature;
        public string weatherDescription;

        public dataStore(string currentTemperature, string weatherDescription)
        {
            this.currentTemperature = currentTemperature;
            this.weatherDescription = weatherDescription;
        }

    }
}
