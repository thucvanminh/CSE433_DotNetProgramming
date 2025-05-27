using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinhThuc_Lab3.Models;

namespace MinhThuc_Lab3.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly Lab3DotnetContext _context;

    public HomeController(ILogger<HomeController> logger, Lab3DotnetContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var books = _context.Books.ToList(); // Lấy từ SQL Server
        return View(books);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
