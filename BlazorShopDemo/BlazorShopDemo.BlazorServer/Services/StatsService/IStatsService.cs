namespace BlazorShopDemo.BlazorServer.Services.StatsService
{
    public interface IStatsService
    {
        Task GetVisits();

        Task IncrementVisists();
    }
}