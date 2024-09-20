using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LibBooking.Models
{
    public class LibrarianAppointmentViewModel
    {
        public int ID { get; set; }

        [Required] // Only add required attribute here as this is a mandatory field.
        [Display(Name = "Librarian Name")]
        public int LibrarianID { get; set; }

        public string LibrarianName { get; set; } // This is not required as it's for display only.

        [Required] // This is the email that will be entered by the user.
        [Display(Name = "User Email")]
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required] // This is the appointment date entered by the user.
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [Required] // Start Time entered by the user.
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        [Required] // End Time entered by the user.
        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }

        public string Notes { get; set; } // Use this field for user's inquiry

        // For drop-down lists of Librarians
        [ValidateNever] // Ensure this doesn't get validated.
        public List<Librarian> Librarians { get; set; } = new List<Librarian>();

        [ValidateNever] // ValidateNever so it doesn't get validated on form submission.
        public SelectList LibrarianSelectList { get; set; }

        public DateTime Date { get; set; }

        [ValidateNever] // Ensure this doesn't get validated.
        public List<LibrarianAppointment> Appointments { get; set; }
    }
}
