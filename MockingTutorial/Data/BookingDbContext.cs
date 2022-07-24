using Microsoft.EntityFrameworkCore;
using MockingTutorial.Models;

namespace MockingTutorial.Data
{
    public class BookingDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
    }
}
