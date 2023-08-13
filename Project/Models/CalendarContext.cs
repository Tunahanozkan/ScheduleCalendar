    using Microsoft.EntityFrameworkCore;
using System;

namespace Project.Models
{
    public class CalendarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-GQ26LQR;database= CalendarSchedule;integrated security = true;TrustServerCertificate=True");
        }
        public DbSet<Calendar> Calendars { get; set; }
    }

    public class Calendar
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Text { get; set; }
        public string? Color { get; set; }
    }

}
