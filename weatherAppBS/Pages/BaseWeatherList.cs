using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherManagement.Models;

namespace weatherAppBS.Pages
{
    public class BaseWeatherList : ComponentBase
    {
        public IEnumerable<WeatherData> WData { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadWeather();
            return base.OnInitializedAsync();
        }

        private void LoadWeather()
        {
            WeatherData w1 = new WeatherData
            {
                Id = 1,
                Date = DateTime.Today,
                Location = "Inne",
                Temp = 23.3M,
                Humid = 42
                
            };
            WData = new List<WeatherData> { w1 };
        }
    }
}
