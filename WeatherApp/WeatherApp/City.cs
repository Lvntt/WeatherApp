using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    public class City
    {
        public City(string name, double temperature, int humidity, double wind)
        {
            this.Name = name;
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Wind = wind;
        }

        public string Name { get; set; }
        public double Temperature { get; set; }
        public int Humidity { get; set; }
        public double Wind { get; set; }
    }
}
