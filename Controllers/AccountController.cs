using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App_Dev_Activity2.Models;

namespace App_Dev_Activity2.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {  
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}