using Microsoft.AspNetCore.Mvc;

namespace finance_control.Controllers;

public class RoleController : Controller
{
    private readonly ILogger<RoleController> _logger;

    public RoleController(ILogger<RoleController> logger)
    { 
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Edit(int roleId)
    {
        return View();
    }

    public IActionResult Delete(int roleId)
    {
        return View();
    }

}