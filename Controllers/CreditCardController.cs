using Microsoft.AspNetCore.Mvc;

namespace finance_control.Controllers;

public class CreditCardController : Controller
{

    private readonly ILogger<CreditCardController> _logger;

    public CreditCardController(ILogger<CreditCardController> logger)
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

    public IActionResult Edit(int creditCardId)
    {
        return View();
    }

    public IActionResult Delete(int creditCardId)
    {
        return View();
    }

}