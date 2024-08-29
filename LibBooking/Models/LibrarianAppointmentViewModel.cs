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
        public IEnumerable<Librarian> Librarians { get; set; } 

        public DateTime Date { get; set; }

        public List<LibrarianAppointment> Appointments { get; set; }
    }
}
