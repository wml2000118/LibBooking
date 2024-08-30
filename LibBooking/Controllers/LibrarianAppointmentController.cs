using LibBooking.Data;
using LibBooking.Models;
using LibBooking.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LibBooking.Controllers
{
    [Route("api/[controller]")]
    public class LibrarianAppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IEmailService _emailService;

        public LibrarianAppointmentController(ApplicationDbContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        // Display all appointments
        [HttpGet("index")]
        public async Task<IActionResult> Index()
        {
            var appointments = await _context.LibrarianAppointments
                .Include(a => a.Librarian)
                .ToListAsync();
            return View(appointments);
        }

        // Create a new appointment, no login required
        [HttpGet("create")]
        public IActionResult Create(DateTime? date)
        {
            var appointmentDate = date ?? DateTime.Today;

            // 获取所有图书管理员
            var librarians = _context.Librarians.ToList();

            // 获取指定日期的所有预约信息
            var appointments = _context.LibrarianAppointments
                .Where(a => a.AppointmentDate == appointmentDate)
                .ToList();

            var viewModel = new LibrarianAppointmentViewModel
            {
                Librarians = librarians,
                Appointments = appointments,
                AppointmentDate = appointmentDate
            };

            return View(viewModel);
        }

        // GET: Display the appointment confirmation page
        [HttpGet("AppointmentConfirmed")]
        public IActionResult AppointmentConfirmed(string librarianId, string librarianName, string appointmentDate, string startTime, string endTime, string notes, string userEmail)
        {
            var viewModel = new LibrarianAppointmentViewModel
            {
                LibrarianID = int.Parse(librarianId),
                LibrarianName = librarianName,
                AppointmentDate = DateTime.Parse(appointmentDate),
                StartTime = TimeSpan.Parse(startTime),
                EndTime = TimeSpan.Parse(endTime),
                Notes = notes,
                UserEmail = userEmail
            };

            return View(viewModel); // 返回确认页面视图
        }

        // POST: Confirm the appointment and send an email
        [HttpPost("confirm")]
        public async Task<IActionResult> ConfirmAppointment([FromBody] LibrarianAppointmentViewModel model)
        {
            // 移除对不需要字段的验证
            ModelState.Remove("Librarians");
            ModelState.Remove("Appointments");

            if (!ModelState.IsValid)
            {
                var errorMessages = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                return BadRequest(new { message = string.Join("; ", errorMessages) });
            }

            var validDomains = new[] { "@student.weltec.ac.nz", "@weltec.ac.nz" };
            var emailDomain = model.UserEmail.Substring(model.UserEmail.IndexOf("@"));

            if (!validDomains.Contains(emailDomain))
            {
                return BadRequest(new { message = "Please use a valid university email address." });
            }

            try
            {
                var appointment = new LibrarianAppointment
                {
                    LibrarianID = model.LibrarianID,
                    UserEmail = model.UserEmail,
                    AppointmentDate = model.AppointmentDate,
                    StartTime = model.StartTime,
                    EndTime = model.EndTime,
                    Notes = model.Notes
                };

                _context.LibrarianAppointments.Add(appointment);
                await _context.SaveChangesAsync();

                var message = $"You have successfully booked an appointment with {model.LibrarianName} at {model.StartTime} on {model.AppointmentDate:yyyy-MM-dd}.";
                await _emailService.SendEmailAsync(model.UserEmail, "Appointment Confirmation", message);

                return Ok(new { message = "Appointment confirmed successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = $"Internal server error: {ex.Message}" });
            }
        }

        [HttpGet("edit/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAppointment(int id)
        {
            var appointment = await _context.LibrarianAppointments
                .Include(a => a.Librarian)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (appointment == null)
            {
                return NotFound();
            }

            var librarians = await _context.Librarians.ToListAsync();

            var viewModel = new LibrarianAppointmentViewModel
            {
                ID = appointment.ID,
                LibrarianID = appointment.LibrarianID,
                UserEmail = appointment.UserEmail,
                AppointmentDate = appointment.AppointmentDate,
                StartTime = appointment.StartTime,
                EndTime = appointment.EndTime,
                Notes = appointment.Notes,
                Librarians = librarians,
                LibrarianSelectList = new SelectList(librarians, "ID", "Name", appointment.LibrarianID)
            };

            return View("Edit", viewModel);
        }
        [HttpPost("edit/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateAppointment(int id, [FromBody] LibrarianAppointmentViewModel viewModel)
        {
            if (viewModel == null)
            {
                return BadRequest("Invalid appointment data.");
            }

            if (id != viewModel.ID)
            {
                return BadRequest("ID mismatch.");
            }

            var appointment = await _context.LibrarianAppointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }

            appointment.LibrarianID = viewModel.LibrarianID;
            appointment.UserEmail = viewModel.UserEmail;
            appointment.AppointmentDate = viewModel.AppointmentDate;
            appointment.StartTime = viewModel.StartTime;
            appointment.EndTime = viewModel.EndTime;
            appointment.Notes = viewModel.Notes;

            try
            {
                _context.Update(appointment);
                await _context.SaveChangesAsync();
                return Redirect("https://localhost:7092/api/LibrarianAppointment/admindashboard");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.LibrarianAppointments.Any(e => e.ID == viewModel.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }




        // Delete appointment, admin only
        [HttpGet("delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appointment = await _context.LibrarianAppointments
                .Include(a => a.Librarian)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }


        [HttpPost("delete/{id}"), ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appointment = await _context.LibrarianAppointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }

            _context.LibrarianAppointments.Remove(appointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AdminDashboard));
        }


        [HttpGet("admindashboard")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AdminDashboard()
        {
            var appointments = await _context.LibrarianAppointments
                .Include(a => a.Librarian)
                .ToListAsync();
            return View(appointments);
        }
    }
}
