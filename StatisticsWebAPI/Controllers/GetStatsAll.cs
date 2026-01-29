using Microsoft.AspNetCore.Mvc;
using AppDB;


[ApiController]
[Route("api/stats/all")]
public class GetStatsAll(AppDbContext _db) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult> GetTopStats()
    {
        if (_db.Statistics.ToList() == null) return NotFound();
        return Ok(_db.Statistics.ToList());
    }
}