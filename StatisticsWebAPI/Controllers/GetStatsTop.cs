using AppDB;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/stats/top")]
public class GetStatsTop(AppDbContext _db) : ControllerBase
{
    [HttpGet("top-10-city-searches")]
       public List<Statistics> GetTopStats()
    {
        return _db.Statistics.ToList();
    }
}