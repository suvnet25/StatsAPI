using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1")]
public class SampleController : ControllerBase
{
    [HttpGet("hello")]
    public IActionResult GetHello()
    {
        return Ok("Hello from SampleController!");
    }
}