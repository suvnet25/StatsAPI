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
            .GroupBy(s => s.Name.ToLower())
            .Select(group => new
            {
                City = group.Key,
                SearchCount = group.Count()
            })
            .OrderByDescending(x => x.SearchCount)
            .Take(5)
            .ToListAsync();
        if (topCities == null) return NotFound();
        return Ok(topCities);
    }
}