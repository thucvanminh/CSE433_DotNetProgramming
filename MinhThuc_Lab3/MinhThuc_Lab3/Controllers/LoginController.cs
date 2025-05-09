using Microsoft.AspNetCore.Mvc;

namespace MinhThuc_Lab3.Controllers;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}