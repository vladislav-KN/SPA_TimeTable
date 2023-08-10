using Microsoft.EntityFrameworkCore;

namespace SPA_TimeTable.Models.Entities;

public class TimeTableContext: DbContext
{
    public DbSet<TimeTable> TTimeTables { get; set; }
    public DbSet<User> TUsers { get; set; }
    
    public TimeTableContext(DbContextOptions<TimeTableContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}