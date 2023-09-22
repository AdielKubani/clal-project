using ClalProjectApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClalProjectApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private HttpClient _httpClient;
        private IConfiguration _configuration;

        public WeatherForecastController(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        [HttpGet("{city}")]
        public async Task<ActionResult<string>> GetWeatherForecast(string city)
        {
            try 
            {
                var weatherUrl = _configuration.GetValue<string>("WeaterForecastApi");
                string weatherUrlWithQuery = string.Format(weatherUrl, city);
                var response = await _httpClient.GetFromJsonAsync<WeatherForecast>(weatherUrlWithQuery);
                var weatherForecast = "the weatehr in " + city + " is: " + response.Current.Temp_C.ToString() + " condition " + response.Current.Condition.text;

                return Ok(weatherForecast);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("ThreeDayWeatherForecast/{city}")]
        public async Task<ActionResult<string>> GetThreeDayWeatherForecast(string city)
        {
            try
            {
                var weatherUrl = _configuration.GetValue<string>("WeaterForecastApi");
                string weatherUrlWithQuery = string.Format(weatherUrl, city);
                var response = await _httpClient.GetFromJsonAsync<WeatherForecast>(weatherUrlWithQuery.ToString());

                return Ok(response.Forecast);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}