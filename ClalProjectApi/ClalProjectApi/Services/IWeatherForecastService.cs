using ClalProjectApi.Models;

namespace ClalProjectApi.Services
{
    public interface IWeatherForecastService
    {
        Task<string> GetWeatherForecast(string city);
        Task<Forecast> GetThreeDayWeatherForecast(string city);
    }
}
