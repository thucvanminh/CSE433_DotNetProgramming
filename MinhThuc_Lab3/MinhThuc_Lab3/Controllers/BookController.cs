using Microsoft.AspNetCore.Mvc;
using MinhThuc_Lab3.Models;

namespace MinhThuc_Lab3.Controllers;

public class BookController : Controller
{
    public static List<Book> _books = new List<Book>
    {
        new Book(1, "Tiếng Việt Lớp 2", "DVA", "Bộ Giáo Dục", new DateTime(2024, 5, 24), "Sách Giáo Khoa", "Sách Giáo Khoa Lớp 2", "/images/book1.png"),
        new Book(2, "Tiếng Việt Lớp 1", "DVA", "Bộ Giáo Dục", new DateTime(2024, 5, 24), "Sách Giáo Khoa", "Sách Giáo Khoa Lớp 1", "/images/book2.png"),
        new Book(3, "Toán Lớp 5", "DVA", "Bộ Giáo Dục", new DateTime(2024, 5, 24), "Sách Giáo Khoa", "Sách Giáo Khoa Lớp 5", "/images/book3.png"),
        new Book(4, "Tiếng Việt Lớp 5", "DVA", "Bộ Giáo Dục", new DateTime(2024, 5, 24), "Sách Giáo Khoa", "Sách Giáo Khoa Lớp 5", "/images/book4.png"),
        new Book(5, "Toán Lớp 5", "DVA", "Bộ Giáo Dục", new DateTime(2024, 5, 24), "Sách Giáo Khoa", "Sách Giáo Khoa Lớp 5", "/images/book5.png")
    };


    public IActionResult Index(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            return NotFound();
        }
        return View(book);
    }

    public IActionResult GetBooks()
    {
        return Json(_books);
    }
}