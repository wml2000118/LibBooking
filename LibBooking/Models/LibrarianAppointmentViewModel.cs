﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LibBooking.Models
{
    public class LibrarianAppointmentViewModel
    {
        public int ID { get; set; }

        [Required]
        public int LibrarianID { get; set; }

        public string LibrarianName { get; set; }

        [Required]
        [Display(Name = "User Email")]
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }

        public string Notes { get; set; } // Use this field for user's inquiry

        // For drop-down lists of Librarians
    
        public List<Librarian> Librarians { get; set; } = new List<Librarian>();
        [ValidateNever] //Need fixing Menglong. Not sure if this is a temporary fix
        public SelectList LibrarianSelectList { get; set; }
        public DateTime Date { get; set; }

        public List<LibrarianAppointment> Appointments { get; set; }
    }
}
