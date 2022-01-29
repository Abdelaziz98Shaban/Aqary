using Microsoft.EntityFrameworkCore;

namespace Aqar.Models
{
    public class AqarEntities : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<RealState> RealStates { get; set; }
        public DbSet<RealStateImage> Images { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserDealRealstate> Deals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Data Source=.;Initial Catalog=Aqar_DB;Integrated Security=True");
            //dbms - name server -db - autha
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define composite key.
            modelBuilder.Entity<UserDealRealstate>()
                .HasKey(deal => new { deal.UserId, deal.RealStateId });
        }
    }
}