using AppDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

[ApiController]
[Route("api/stats/top")]
public class GetStatsTop(AppDbContext _db) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult> GetTopFiveCities()
    {
        var topCities = await _db.Statistics
            .GroupBy(s => s.Name)
            .Select(group => new
            {
                City = group.Key,
                SearchCount = group.Count()
            })
            .OrderByDescending(x => x.SearchCount)
            .Take(5)
            .ToListAsync();

        return Ok(topCities);
    }
}