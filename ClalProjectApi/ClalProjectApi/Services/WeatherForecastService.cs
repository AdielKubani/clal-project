using ClalProjectApi.Models;

namespace ClalProjectApi.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private HttpClient _httpClient;
        private IConfiguration _configuration;

        public WeatherForecastService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<string> GetWeatherForecast(string city)
        {
             var weatherUrl = _configuration.GetValue<string>("WeaterForecastApi");
             string weatherUrlWithQuery = string.Format(weatherUrl, city);
             var response = await _httpClient.GetFromJsonAsync<WeatherForecast>(weatherUrlWithQuery);
             var weatherForecast = "the weatehr in " + city + " is: " + response.Current.Temp_C.ToString() + " condition " + response.Current.Condition.Text;
            
             return weatherForecast;
        }

        public async Task<Forecast> GetThreeDayWeatherForecast(string city)
        {
            var weatherUrl = _configuration.GetValue<string>("WeaterForecastApi");
            string weatherUrlWithQuery = string.Format(weatherUrl, city);
            var response = await _httpClient.GetFromJsonAsync<WeatherForecast>(weatherUrlWithQuery.ToString());

            return response.Forecast;
        }
    }
}
