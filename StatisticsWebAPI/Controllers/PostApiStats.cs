using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/stats")]
public class PostApiStats : ControllerBase
{
    [HttpPost]
    public IActionResult PostStats()
    {
        return Ok("Hello from SampleController!");
    }
}