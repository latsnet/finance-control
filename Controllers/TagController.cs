using Microsoft.AspNetCore.Mvc;

namespace finance_control.Controllers;

public class TagController : Controller
{

    private readonly ILogger<TagController> _logger;

    public TagController(ILogger<TagController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

}