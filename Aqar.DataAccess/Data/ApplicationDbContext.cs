using Aqar.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Aqar.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<RealState> RealStates { get; set; }
        public DbSet<RealStateImage> Images { get; set; }
        public DbSet<Category> Categories { get; set; }

        //public DbSet<UserDealRealstate> Deals { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // Define composite key.
        //    modelBuilder.Entity<UserDealRealstate>()
        //        .HasKey(deal => new { deal.UserId, deal.RealStateId });


        //}
    }
}