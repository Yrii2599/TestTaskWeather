using Providers.Models;

namespace Providers.Absctractions
{
    public interface IWeatherProvider
    {
        Task<WeatherData> GetWeatherDataByStaticonId(string stationId);
    }
}
