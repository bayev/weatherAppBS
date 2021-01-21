using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using weatherAppBS.Models;
using WeatherManagement.Models;

namespace WeatherManagement.Api.Models
{
    public class WeatherDataRepository : IWeatherDataRepository
    {
        private readonly AppDbContext appDbContext;

        public WeatherDataRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<IEnumerable<WeatherData>> GetWeatherData()
        {
            return await appDbContext.WeatherData.ToListAsync();
        }

        public async Task<WeatherData> GetWeatherId(int weatherDataId)
        {
            return await appDbContext.WeatherData.FirstOrDefaultAsync(e => e.Id == weatherDataId);
        }
    }
}
