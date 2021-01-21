using System;

namespace WeatherManagement.Models
{
    public class WeatherData
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public decimal Temp { get; set; }
        public int Humid { get; set; }
    }
}
