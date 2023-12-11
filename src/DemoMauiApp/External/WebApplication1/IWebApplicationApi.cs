using DemoLibrary;
using Refit;

namespace DemoMauiApp.External.DemoAPI
{
    public interface IWebApplicationApi
    {
        [Get("/WeatherForecast")]
        Task<IEnumerable<WeatherForecast>> GetWeatherForecasts();
    }
}
