using Microsoft.AspNetCore.Mvc;

namespace FEA.Controllers;

[ApiController]
[Route("/api/home")]

public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Welcome to the home page!");
    }
}
