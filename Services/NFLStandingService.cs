using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using StatsWizard.Models.NFL; // Make sure this namespace is used

namespace StatsWizard.Services
{
    public class NFLStandingService
    {
        private readonly HttpClient _httpClient;

        public NFLStandingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<NFLStandingModel> GetStandingsAsync() // Correct the return type to NFLStandingModel
        {
            var apiUrl = "https://api.sportradar.com/nfl/official/trial/v7/en/seasons/2024/REG/standings/season.json?api_key=aC2Tp4E42T2l0i7K1kSGy5GGkbmds4Im5X6WuIRS";
            return await _httpClient.GetFromJsonAsync<NFLStandingModel>(apiUrl); // Return NFLStandingModel
        }
    }
}
