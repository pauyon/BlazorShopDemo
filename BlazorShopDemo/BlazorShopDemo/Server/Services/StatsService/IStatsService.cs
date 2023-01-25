namespace BlazorShopDemo.Server.Services.StatsService
{
    public interface IStatsService
    {
        Task<int> GetVisists();

        Task IncrementVisists();
    }
}