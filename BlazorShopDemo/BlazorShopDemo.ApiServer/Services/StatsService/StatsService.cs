﻿using BlazorShopDemo.ApiServer.Data;
using BlazorShopDemo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorShopDemo.ApiServer.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly DataContext _context;

        public StatsService(DataContext context)
        {
            _context = context;
        }

        public async Task<int> GetVisists()
        {
            var stats = await _context.Stats.FirstOrDefaultAsync();
            if (stats == null) return 0;
            return stats.Visits;
        }

        public async Task IncrementVisists()
        {
            var stats = await _context.Stats.FirstOrDefaultAsync();
            if (stats == null)
            {
                _context.Stats.Add(new Stats { Visits = 1, LastVisit = DateTime.Now });
            }
            else
            {
                stats.Visits++;
                stats.LastVisit = DateTime.Now;
            }

            await _context.SaveChangesAsync();
        }
    }
}