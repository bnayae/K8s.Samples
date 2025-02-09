using Microsoft.AspNetCore.Mvc;

namespace _01_Hellow_Dockerfile.Controllers;

[ApiController]
[Route("[controller]")]
public class DemoController : ControllerBase
{
    private readonly ILogger<DemoController> _logger;

    public DemoController(ILogger<DemoController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<string> GetAsync()
    {
        await Task.Delay(1000);
        return "Hello World!";
    }
}