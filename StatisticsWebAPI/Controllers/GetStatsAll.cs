using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/stats")]
public class GetStatsAll : ControllerBase
{
    [HttpGet]
    public IActionResult GetTopStats()
    {
        return Ok("Hello from SampleController!");
    }
}