using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/stats")]
public class GetStatsAll : ControllerBase
{
    [HttpPost]
    public IActionResult GetTopStats()
    {
        return Ok("Hello from SampleController!");
    }
}