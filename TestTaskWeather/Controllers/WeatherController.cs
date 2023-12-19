using Microsoft.AspNetCore.Mvc;
using Providers.Absctractions;
using Providers.Models;

namespace TestTaskWeather.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;

        private readonly IWeatherProvider _weatherProvider;

        public WeatherController(ILogger<WeatherController> logger,
            IWeatherProvider weatherProvider)
        {
            _logger = logger;
            _weatherProvider = weatherProvider;
        }

        [HttpGet("/rainfall/id/{stationId}/readings")]
        public async Task<WeatherData> GetWeatherByStationId([FromRoute] string stationId)
        {
            return await _weatherProvider.GetWeatherDataByStaticonId(stationId);
        }
    }
}