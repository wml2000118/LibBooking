using System;
using System.Collections.Generic;

namespace LibBooking.Models
{
    public class RoomReservationViewModel
    {
        public DateTime Date { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
