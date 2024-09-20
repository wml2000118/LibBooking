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

            var validDomains = new[] { "@student.weltec.ac.nz", "@weltec.ac.nz", "@whitireianz.student.ac.nz" };
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

                var message = $@"
<p>Dear {model.UserEmail},</p>
<p>We are pleased to inform you that your appointment with {model.LibrarianName} has been successfully scheduled. Below are the details of your appointment:</p>
<ul>
    <li><strong>Date:</strong> {model.AppointmentDate:dddd, MMMM dd, yyyy}</li>
    <li><strong>Start Time:</strong> {model.StartTime}</li>
    <li><strong>End Time:</strong> {model.EndTime}</li>
</ul>
<p>If you need to reschedule or cancel your appointment, please contact us at least 24 hours in advance.</p>
<p>Thank you for choosing our services. We look forward to seeing you.</p>
<p>Best regards,<br/>The Library Team</p>
";

                await _emailService.SendEmailAsync(model.UserEmail, "Appointment Confirmation", message);


                // 返回一个指示成功的 JSON 响应
                return Ok(new { message = "Appointment confirmed successfully!", redirectUrl = Url.Action("Create") });
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
        //[HttpPost("edit/{id}")]
        //[Authorize(Roles = "Admin")]
        //public async Task<IActionResult> UpdateAppointment(int id, [FromForm] LibrarianAppointmentViewModel viewModel)
        //{
        //    if (viewModel == null)
        //    {
        //        return BadRequest("Invalid appointment data.");
        //    }

        //    if (id != viewModel.ID)
        //    {
        //        ModelState.AddModelError("", "ID mismatch.");
        //        return View("Edit", viewModel);
        //    }

        //    // Ensure EndTime is after StartTime
        //    if (viewModel.StartTime >= viewModel.EndTime)
        //    {
        //        ModelState.AddModelError("", "End time must be after start time.");
        //        return View("Edit", viewModel);
        //    }

        //    // Optional: Validate if appointment already exists for the same librarian and time
        //    var overlappingAppointment = await _context.LibrarianAppointments
        //        .Where(a => a.LibrarianID == viewModel.LibrarianID && a.AppointmentDate == viewModel.AppointmentDate)
        //        .Where(a => a.StartTime < viewModel.EndTime && a.EndTime > viewModel.StartTime && a.ID != id)
        //        .FirstOrDefaultAsync();

        //    if (overlappingAppointment != null)
        //    {
        //        ModelState.AddModelError("", "This time slot is already booked.");
        //        return View("Edit", viewModel);
        //    }

        //    var appointment = await _context.LibrarianAppointments.FindAsync(id);
        //    if (appointment == null)
        //    {
        //        return NotFound();
        //    }

        //    appointment.LibrarianID = viewModel.LibrarianID;
        //    appointment.UserEmail = viewModel.UserEmail;
        //    appointment.AppointmentDate = viewModel.AppointmentDate;
        //    appointment.StartTime = viewModel.StartTime;
        //    appointment.EndTime = viewModel.EndTime;
        //    appointment.Notes = viewModel.Notes;

        //    try
        //    {
        //        _context.Update(appointment);
        //        await _context.SaveChangesAsync();

        //        // Optional: Use TempData to pass success message
        //        TempData["SuccessMessage"] = "Appointment updated successfully.";
        //        return RedirectToAction("AdminDashboard");
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!_context.LibrarianAppointments.Any(e => e.ID == viewModel.ID))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "An error occurred while updating the appointment.");
        //            return View("Edit", viewModel);
        //        }
        //    }
        //}


        [HttpPost("edit/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateAppointment(int id, [FromForm] LibrarianAppointmentViewModel viewModel)
        {
            if (viewModel == null)
            {
                return BadRequest("Invalid appointment data.");
            }

            if (id != viewModel.ID)
            {
                ModelState.AddModelError("", "ID mismatch.");
            }

            // Manually remove the unnecessary properties from ModelState
            ModelState.Remove("Appointments");
            ModelState.Remove("LibrarianName");

            // Ensure EndTime is after StartTime
            if (viewModel.StartTime >= viewModel.EndTime)
            {
                ModelState.AddModelError("", "End time must be after start time.");
            }

            // Validate if appointment already exists for the same librarian and time
            var overlappingAppointment = await _context.LibrarianAppointments
                .Where(a => a.LibrarianID == viewModel.LibrarianID && a.AppointmentDate == viewModel.AppointmentDate)
                .Where(a => a.StartTime < viewModel.EndTime && a.EndTime > viewModel.StartTime && a.ID != id)
                .FirstOrDefaultAsync();

            if (overlappingAppointment != null)
            {
                ModelState.AddModelError("", "This time slot is already booked.");
            }

            // Retrieve the LibrarianName from the database
            viewModel.LibrarianName = await _context.Librarians
                .Where(l => l.ID == viewModel.LibrarianID)
                .Select(l => l.Name)
                .FirstOrDefaultAsync();

            // If there are validation errors, re-render the view
            if (!ModelState.IsValid)
            {
                // Ensure the LibrarianSelectList is set so that the dropdown can be populated correctly
                viewModel.LibrarianSelectList = new SelectList(_context.Librarians, "ID", "Name", viewModel.LibrarianID);
                return View("Edit", viewModel);
            }

            // Find the appointment to update
            var appointment = await _context.LibrarianAppointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }

            // Update the appointment properties
            appointment.LibrarianID = viewModel.LibrarianID;
            appointment.UserEmail = viewModel.UserEmail;
            appointment.AppointmentDate = viewModel.AppointmentDate;
            appointment.StartTime = viewModel.StartTime;
            appointment.EndTime = viewModel.EndTime;
            appointment.Notes = viewModel.Notes;

            try
            {
                // Save the changes to the database
                _context.Update(appointment);
                await _context.SaveChangesAsync();

                // Use TempData to pass success message
                TempData["SuccessMessage"] = "Appointment updated successfully.";
                return RedirectToAction("AdminDashboard");
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.LibrarianAppointments.Any(e => e.ID == viewModel.ID))
                {
                    return NotFound();
                }
                else
                {
                    ModelState.AddModelError("", "An error occurred while updating the appointment.");
                    viewModel.LibrarianName = await _context.Librarians
                        .Where(l => l.ID == viewModel.LibrarianID)
                        .Select(l => l.Name)
                        .FirstOrDefaultAsync();
                    viewModel.LibrarianSelectList = new SelectList(_context.Librarians, "ID", "Name", viewModel.LibrarianID);
                    return View("Edit", viewModel);
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
