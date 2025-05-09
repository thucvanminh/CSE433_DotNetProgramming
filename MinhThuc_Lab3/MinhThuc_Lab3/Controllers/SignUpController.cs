using Microsoft.AspNetCore.Mvc;

namespace MinhThuc_Lab3.Controllers;

public class SignUpController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}