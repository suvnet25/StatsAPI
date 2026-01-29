using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/stats")]
public class GetStatsAll : ControllerBase
{
    [HttpGet("All-city-searches")]
    public IActionResult GetTopStats()
    {
        return Ok("Hello from SampleController!");
    }
}