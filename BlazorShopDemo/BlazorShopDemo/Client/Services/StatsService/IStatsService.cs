namespace BlazorShopDemo.Client.Services.StatsService
{
    public interface IStatsService
    {
        Task GetVisits();

        Task IncrementVisists();
    }
}