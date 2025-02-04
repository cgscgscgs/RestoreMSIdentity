using Microsoft.EntityFrameworkCore;
using RestoreMSIdentity.Models;

namespace RestoreMSIdentity.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<SiteModel> Sites { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SiteModel>().HasData(
                new SiteModel { Id = 1, Name = "Site A", Description = "Site A", ImageUrl = "/images/siteA.jpg" },
                new SiteModel { Id = 2, Name = "Site B", Description = "This i an awesome site", ImageUrl = "/images/siteB.jpg" },
                new SiteModel { Id = 3, Name = "Site C", Description = "This is a river and woods", ImageUrl = "/images/siteC.jpg" }
            );
        }
    }
}
