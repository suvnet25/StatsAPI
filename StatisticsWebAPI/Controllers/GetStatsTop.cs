using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/stats/top")]
public class GetStatsTop : ControllerBase
{
    [HttpGet]
    public IActionResult GetTopStats()
    {
        return Ok("Hello from SampleController!");
    }
}