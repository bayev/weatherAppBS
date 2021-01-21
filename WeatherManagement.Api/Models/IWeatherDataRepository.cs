using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherManagement.Models;

namespace WeatherManagement.Api.Models
{
    public interface IWeatherDataRepository
    {
        Task<IEnumerable<WeatherData>> GetWeatherData();
        Task<WeatherData> GetWeatherId(int weatherDataId);
    }
}
