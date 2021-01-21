
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using WeatherManagement.Api.Models;

//namespace WeatherManagement.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class WeatherController : ControllerBase
//    {
//        private readonly IWeatherDataRepository weatherDataRepository;

//        public WeatherController (IWeatherDataRepository weatherDataRepository)
//        {
//            this.weatherDataRepository = weatherDataRepository;
//        }
//        [HttpGet]
//        public async Task<AcitionResult> GetWeatherData()
//        {
//            return Ok(await weatherDataRepository.GetWeatherData());
//        }
//    }
//}
