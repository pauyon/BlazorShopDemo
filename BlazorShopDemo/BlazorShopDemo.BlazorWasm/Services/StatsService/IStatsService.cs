namespace BlazorShopDemo.BlazorWasm.Services.StatsService
{
    public interface IStatsService
    {
        Task GetVisits();

        Task IncrementVisists();
    }
}