using LibBooking.Data;
using LibBooking.Models;
using LibBooking.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibBooking.Controllers
{
    [Route("api/[controller]")]

    public class ReservationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IEmailService _emailService;

        public ReservationsController(ApplicationDbContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }

        [HttpGet("index")]
        public IActionResult Index(DateTime? date)
        {
            if (date == null)
            {
                date = DateTime.Today;
            }

            // 获取所有房间信息
            var rooms = _context.Rooms.ToList();

            // 获取指定日期的所有预定
            var reservations = _context.Reservations
                .Where(r => r.ReservationDate == date)
                .ToList();

            // 将房间信息和预定信息传递到视图
            var model = new RoomReservationViewModel
            {
                Date = date.Value,
                Rooms = rooms,
                Reservations = reservations
            };

            return View(model);
        }


        // 获取预订信息的 API 端点
        [HttpGet("get-reservations")]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservations([FromQuery] int? roomID, [FromQuery] DateTime? start, [FromQuery] DateTime? end)
        {
            var query = _context.Reservations.AsQueryable();

            if (roomID.HasValue)
            {
                query = query.Where(r => r.RoomID == roomID);
            }

            if (start.HasValue && end.HasValue)
            {
                query = query.Where(r => r.ReservationDate >= start && r.ReservationDate <= end);
            }

            return await query.Include(r => r.Room).ToListAsync();
        }

        // 提交时间方法
        [HttpPost("submit-time")]
        public IActionResult SubmitTime(int roomID, int time, DateTime reservationDate)
        {
            // 验证传入的数据
            if (roomID <= 0 || time < 0 || time > 23)
            {
                return BadRequest(new { message = "Invalid input data." });
            }

            // 查找所选的房间
            var selectedRoom = _context.Rooms.FirstOrDefault(r => r.ID == roomID);
            if (selectedRoom == null)
            {
                return BadRequest(new { message = "Invalid Room ID." });
            }

            // 构建 EmailValidationViewModel 模型
            var model = new EmailValidationViewModel
            {
                Room = selectedRoom.RoomName,
                ID = roomID,
                Time = time,
                Date = reservationDate
            };

            // 返回视图，并将模型传递到视图中
            return View("EmailValidation", model);
        }




        // 验证邮箱
        [HttpPost("email-validation")]
        public async Task<IActionResult> EmailValidation(EmailValidationViewModel model)
        {
            Console.WriteLine($"EmailValidation called with Room: {model.Room}, ID: {model.ID}, Time: {model.Time}");

            var validDomains = new[] { "@student.weltec.ac.nz", "@weltec.ac.nz" };
            var emailDomain = model.Email.Substring(model.Email.IndexOf("@"));

            if (!validDomains.Contains(emailDomain))
            {
                ViewBag.Message = "提交失败，请使用学校邮箱（@student.weltec.ac.nz 或 @weltec.ac.nz）";
                return View(model); // 返回当前视图，并显示错误消息
            }

            var selectedRoom = _context.Rooms.FirstOrDefault(r => r.ID == model.ID);
            if (selectedRoom == null)
            {
                ViewBag.Message = "Invalid Room ID.";
                return View(model); // 返回当前视图，并显示错误消息
            }

            try
            {
                int timeAsInt = int.Parse(model.Time.ToString());

                var startTime = new TimeSpan(timeAsInt, 0, 0); // 使用转换后的整数来创建 TimeSpan
                // 解析时间部分为整型
                var endTime = startTime.Add(TimeSpan.FromHours(1));

                var reservation = new Reservation
                {
                    RoomID = model.ID,
                    ReservationDate = model.Date,
                    StartTime = startTime,
                    EndTime = endTime,
                    Email = model.Email
                };

                _context.Reservations.Add(reservation);
                await _context.SaveChangesAsync();
                Console.WriteLine("Reservation saved to database.");

                var message = $"You have successfully booked the room {model.Room} at {model.Time}:00 on {model.Date:yyyy-MM-dd}.";
                await _emailService.SendEmailAsync(model.Email, "Room Booking Confirmation", message);
                Console.WriteLine("Confirmation email sent.");

                ViewBag.Message = "提交成功，预订确认邮件已发送到您的邮箱。";
                /*return View(model);*/ // 返回当前视图，并显示成功消息
                return View("Index", new RoomReservationViewModel
                {
                    Date = DateTime.Today,
                    Rooms = _context.Rooms.ToList(),
                    Reservations = _context.Reservations.Where(r => r.ReservationDate == DateTime.Today).ToList()
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving reservation: {ex.Message}");
                ViewBag.Message = $"保存预订信息时发生错误: {ex.Message}";
                return View(model); // 返回当前视图，并显示错误消息
            }
        }




        // 创建预订
        [HttpPost]
        public async Task<ActionResult<Reservation>> CreateReservation([FromBody] Reservation reservationDto)
        {
            var validEmailDomains = new[] { "@student.weltec.ac.nz", "@weltec.ac.nz" };
            var emailDomain = reservationDto.Email.Substring(reservationDto.Email.IndexOf("@"));

            if (!validEmailDomains.Contains(emailDomain))
            {
                return BadRequest("Invalid email domain. Please use a valid WelTec email address.");
            }

            var reservation = new Reservation
            {
                Email = reservationDto.Email,
                RoomID = reservationDto.RoomID,
                ReservationDate = reservationDto.ReservationDate,
                StartTime = reservationDto.StartTime,
                EndTime = reservationDto.EndTime
            };

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetReservations), new { id = reservation.ID }, reservation);
        }

        // GET: Manage reservations - Admin only
        [HttpGet("manage")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Manage()
        {
            var reservations = await _context.Reservations.ToListAsync();
            return View(reservations);
        }

        // GET: Reservations/Edit/5
        [HttpGet("edit/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return View(reservation);
        }


        // POST: Reservations/Edit/5
        [HttpPost("edit/{id}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Reservation reservation)
        {
            ModelState.Remove("Room");

            if (id != reservation.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Manage)); // Redirect to Manage view after saving
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Reservations.Any(e => e.ID == reservation.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            // 如果 ModelState 无效，显示错误信息
            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
            ViewBag.Errors = errors; // 可以显示在视图中，帮助诊断问题

            return View(reservation); // 返回当前视图以显示错误信息
        }


        // GET: Reservations/Delete/5
        [HttpGet("delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .FirstOrDefaultAsync(m => m.ID == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost("delete/{id}"), ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
