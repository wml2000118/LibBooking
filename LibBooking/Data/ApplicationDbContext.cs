using System.Collections.Generic;
using LibBooking.Models;
using Microsoft.EntityFrameworkCore;

namespace LibBooking.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed data for rooms
            builder.Entity<Room>().HasData(
                new Room { ID = 1, RoomName = "Room A", Capacity = 10, Description = "Description for Room A" },
                new Room { ID = 2, RoomName = "Room B", Capacity = 20, Description = "Description for Room B" },
                new Room { ID = 3, RoomName = "Room C", Capacity = 30, Description = "Description for Room C" },
                new Room { ID = 4, RoomName = "Room D", Capacity = 40, Description = "Description for Room D" }
            );
        }
    }
}
