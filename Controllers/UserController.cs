using Microsoft.AspNetCore.Mvc;

namespace finance_control.Controllers;

public class UserController : Controller
{

    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    { 
        _logger = logger;
    }

    public IActionResult Index()
    { 
        return View();
    }

}