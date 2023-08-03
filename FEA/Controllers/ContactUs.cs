using Microsoft.AspNetCore.Mvc;

namespace FEA.Controllers;

[ApiController]
[Route("/api/contact-us")]
public class ContactUs : ControllerBase
{
    [HttpGet]
    public IActionResult Result()
    {
        return Ok("Write us here. Don't be shy. Go ahead!");
    }
}