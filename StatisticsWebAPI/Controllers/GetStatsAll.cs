using AppDB;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/stats/all")]
public class GetStatsAll(AppDbContext _db) : ControllerBase
{
    [HttpGet("all-city-searches")]
    public List<Statistics> GetTopStats()
    {
        return _db.Statistics.ToList();
    }
}