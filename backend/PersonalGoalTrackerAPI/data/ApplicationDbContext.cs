using Microsoft.EntityFrameworkCore;
using PersonalGoalTrackerAPI.Models;

namespace PersonalGoalTrackerAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Goal> Goals { get; set; }
    }
}
