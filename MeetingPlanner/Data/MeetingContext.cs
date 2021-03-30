using MeetingPlanner.Models;
using Microsoft.EntityFrameworkCore;


namespace MeetingPlanner.Data
{
    public class MeetingContext : DbContext
    {
        public MeetingContext(DbContextOptions<MeetingContext> options) : base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Assignment> Assignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>().ToTable("Meeting");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Assignment>().ToTable("Assignment");
        }
    }
}
