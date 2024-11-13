using Gym.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gym.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole,
string>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GymClass> GymClasses { get; set; } = default!;
        public DbSet<ApplicationUserGymClass> ApplicationUserGymClass { get; set; } = default!; 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUserGymClass>().HasKey(e => new {e.ApplicationUserId, e.GymClassId});
        }
    }
}
