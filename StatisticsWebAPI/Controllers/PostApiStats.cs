using Microsoft.AspNetCore.Mvc;
using AppDB;


[ApiController]
[Route("api/stats")]
public class PostApiStats(AppDbContext _db) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<Statistics>> PostStatistics(Statistics stats)
    {
        // POST /api/stats. 
        // Tar emot JSON med vilken stad som söktes på samt,
        // vilket IP som gjorde requesten, 
        // och sparar detta i en databas.

        stats.IPAddress = HttpContext.Connection.RemoteIpAddress?.ToString() ?? "UnknownIP";
        _db.Statistics.Add(stats);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(PostStatistics), new { id = stats.Id }, stats);
    }
}