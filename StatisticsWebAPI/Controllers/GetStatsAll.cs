using AppDB;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/stats")]
public class GetStatsAll(AppDbContext _db) : ControllerBase
{
    [HttpGet("All-city-searches")]
    public List<Statistics> GetTopStats()
    {
        return _db.Statistics.ToList();
    }
}