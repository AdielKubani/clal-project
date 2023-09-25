using ClalProjectApi.Models;
using ClalProjectApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClalProjectApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet("{city}")]
        public async Task<ActionResult<string>> GetWeatherForecast(string city)
        {
            try 
            {
                var weatherForecast = await _weatherForecastService.GetWeatherForecast(city);

                return Ok(weatherForecast);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ThreeDayWeatherForecast/{city}")]
        public async Task<ActionResult<Forecast>> GetThreeDayWeatherForecast(string city)
        {
            try
            {
                var weatherForecastForThreeDays = await _weatherForecastService.GetThreeDayWeatherForecast(city);

                return Ok(weatherForecastForThreeDays);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}