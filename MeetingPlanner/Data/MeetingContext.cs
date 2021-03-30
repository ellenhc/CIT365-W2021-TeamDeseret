using MeetingPlanner.Models;
using Microsoft.EntityFrameworkCore;


namespace MeetingPlanner.Data
{
    public class MeetingContext : DbContext
    {
        public MeetingContext(DbContextOptions<MeetingContext> options)
            : base(options)
        {
        }

        public DbSet<Meeting> Meeting { get; set; }
    }
}
