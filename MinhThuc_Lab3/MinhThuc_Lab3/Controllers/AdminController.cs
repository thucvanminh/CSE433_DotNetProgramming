using Microsoft.AspNetCore.Mvc;

namespace MinhThuc_Lab3.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            TempData["AdminMenuItems"] = new string[] { "Dashboard", "Users", "Books", "Loans", "Categories", "Authors" };
            return View();
        }

        public IActionResult Users()
        {
            TempData["AdminMenuItems"] = new string[] { "Dashboard", "Users", "Books", "Loans", "Categories", "Authors" };
            return View();
        }

        public IActionResult Books()
        {
            TempData["AdminMenuItems"] = new string[] { "Dashboard", "Users", "Books", "Loans", "Categories", "Authors" };
            return View();
        }
    }
}
