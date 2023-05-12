namespace BlazorShopDemo.ApiServer.Services.StatsService
{
    public interface IStatsService
    {
        Task<int> GetVisists();

        Task IncrementVisists();
    }
}