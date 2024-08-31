using LibBooking.Data;
using LibBooking.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibBooking.Controllers
{
    public class LibrarianController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Constructor to inject the DbContext
        public LibrarianController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // 示例数据
            var librarians = _context.Librarians.ToList();

            return View(librarians);
        }
    }
}
