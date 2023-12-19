using Microsoft.AspNetCore.Http;
using Providers.Absctractions;
using Providers.Models;
using System.Text.Json;

namespace Providers.Providers
{
    internal class WeatherProvider : IWeatherProvider
    {
        public HttpClient HttpClient { get; set; }

        public WeatherProvider(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
        public async Task<WeatherData> GetWeatherDataByStaticonId(string stationId)
        {
            HttpResponseMessage response = await HttpClient.GetAsync($"http://environment.data.gov.uk/flood-monitoring/id/measures/{stationId}");

            var responseContent = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<WeatherData>(responseContent);
        }
    }
}
