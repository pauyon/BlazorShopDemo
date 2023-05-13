using Blazored.LocalStorage;

namespace BlazorShopDemo.BlazorServer.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public StatsService(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }

        public async Task GetVisits()
        {
            var visists = int.Parse(await _httpClient.GetStringAsync("api/stats"));
            Console.WriteLine($"Visits: {visists}");
        }

        public async Task IncrementVisists()
        {
            var lastVisit = await _localStorageService.GetItemAsync<DateTime?>("lastVisit");
            if (lastVisit == null || ((DateTime)lastVisit).Date != DateTime.Now.Date)
            {
                await _localStorageService.SetItemAsync("lastVisit", DateTime.Now);
                await _httpClient.PostAsync("api/stats", null);
            }
        }
    }
}