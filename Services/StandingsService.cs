using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using StatsWizard.Models;

namespace StatsWizard.Services
{
    public class StandingsService
    {
        private readonly HttpClient _httpClient;

        public StandingsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<StandingsModel> GetStandingsAsync()
        {
            var apiUrl = "https://api.sportradar.com/nba/trial/v8/en/seasons/2023/REG/standings.json?api_key=aC2Tp4E42T2l0i7K1kSGy5GGkbmds4Im5X6WuIRS";
            return await _httpClient.GetFromJsonAsync<StandingsModel>(apiUrl);
        }
    }
}
