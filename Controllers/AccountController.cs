using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using finance_control.Models;

namespace finance_control.Controllers;

public class AccountController : Controller
{

    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


}