using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using finance_control.Models;

namespace finance_control.Controllers;

public class BankController : Controller
{

    private readonly ILogger<BankController> _logger;

    public BankController(ILogger<BankController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

}