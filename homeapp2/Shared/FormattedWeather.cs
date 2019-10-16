using System;
using System.Collections.Generic;
using System.Text;

namespace homeapp2.Shared
{
    public class FormattedWeather
    {
        public DateTime Date { get; set; }
        public string Temperature { get; set; }
        public string WeatherType { get; set; }
        public string ThunderProbability { get; set; }
        public string WindSpeeds { get; set; }
        public string Icon { get; set; }

    }
}
