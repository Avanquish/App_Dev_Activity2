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
    
    public IActionResult Logins(string Email, string Password)
    {
        if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
        {
            ModelState.AddModelError("", "Email and Password are required.");
            return View();
        }
        return RedirectToAction("Index", "Home");
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Registration()
    {
        TempData["SuccessMessage"] = "Registration Successful. Please log in.";

        return RedirectToAction("Login");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}