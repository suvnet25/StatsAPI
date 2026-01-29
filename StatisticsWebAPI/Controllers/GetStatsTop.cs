using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/stats")]
public class GetStatsTop : ControllerBase
{
    [HttpPost]
    public IActionResult GetTopStats()
    {
        return Ok("Hello from SampleController!");
    }
}