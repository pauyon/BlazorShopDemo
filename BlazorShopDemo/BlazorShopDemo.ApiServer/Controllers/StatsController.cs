using BlazorShopDemo.ApiServer.Services.StatsService;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShopDemo.ApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IStatsService _statsService;

        public StatsController(IStatsService StatsService)
        {
            _statsService = StatsService;
        }

        [HttpGet]
        public async Task<ActionResult<int>> GetVisits()
        {
            return await _statsService.GetVisists();
        }

        [HttpPost]
        public async Task IncrementVisits()
        {
            await _statsService.IncrementVisists();
        }
    }
}