using Microsoft.AspNetCore.Mvc;

namespace finance_control.Controllers;

public class TransactionController : Controller
{

    private readonly ILogger<TransactionController> _logger;

    public TransactionController(ILogger<TransactionController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
}