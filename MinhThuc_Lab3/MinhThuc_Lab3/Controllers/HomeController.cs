using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinhThuc_Lab3.Models;

namespace MinhThuc_Lab3.Controllers;

public class HomeController : Controller
{
    private readonly Lab3DotnetContext _context;

    public HomeController(Lab3DotnetContext context)
    {
        _context = context;
    }

    public IActionResult Index(string search)
    {
        TempData["MenuItems"] = new string[] { "Home", "Books", "About", "Contact", "Admin" };
        var carousels = _context.Carousels.Where(c => c.IsActive).OrderBy(c => c.Order).ToList();
        return View(carousels);
    }
}
