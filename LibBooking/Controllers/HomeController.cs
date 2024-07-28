using LibBooking.Data;
using LibBooking.Models;
using LibBooking.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LibBooking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IEmailService _emailService;

        public HomeController(ApplicationDbContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        public async Task<IActionResult> Index(DateTime? date)
        {
            if (date == null)
            {
                date = DateTime.Today;
            }

            var rooms = await _context.Rooms.ToListAsync();
            var reservations = await _context.Reservations
                .Where(r => r.ReservationDate == date)
                .ToListAsync();

            var model = new RoomReservationViewModel
            {
                Date = date.Value,
                Rooms = rooms,
                Reservations = reservations
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult SubmitTime(string room, int time)
        {
            var model = new EmailValidationViewModel
            {
                Room = room,
                Time = time,
                Date = DateTime.Today // 您可以根据需要传递日期
            };
            return View("EmailValidation", model);
        }

        [HttpPost]
        public async Task<IActionResult> ValidateEmail(EmailValidationViewModel model)
        {
            var validDomains = new[] { "@student.weltec.ac.nz", "@weltec.ac.nz" };
            var emailDomain = model.Email.Substring(model.Email.IndexOf("@"));

            if (!validDomains.Contains(emailDomain))
            {
                ModelState.AddModelError(string.Empty, "Invalid email domain. Please use a valid WelTec email address.");
                return View("EmailValidation", model);
            }

            // 发送确认邮件
            var message = $"You have successfully booked the room {model.Room} at {model.Time}:00 on {model.Date.ToString("yyyy-MM-dd")}.";
            await _emailService.SendEmailAsync(model.Email, "Room Booking Confirmation", message);

            // 在这里处理预订信息的存储等操作

            return RedirectToAction("Index");
        }
    }
}
