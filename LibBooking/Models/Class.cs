﻿using System.ComponentModel.DataAnnotations;

namespace LibBooking.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

    public class Room
    {
        //[Key]
        public int ID { get; set; }
        public string RoomName { get; set; }
        [Display(Name = "Room Capacity")]
        public int Capacity { get; set; }
        public string Facilities { get; set; }
    }

    public class Reservation
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public int RoomID { get; set; }
        public Room Room { get; set; }
        public DateTime ReservationDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }

  
    public class LibrarianAppointment
    {
        public int ID { get; set; }
        public int LibrarianID { get; set; }
        public Librarian Librarian { get; set; }
        public string UserEmail { get; set; }

        public DateTime AppointmentDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Notes { get; set; }  // Use this field for user's inquiry
    }



}
