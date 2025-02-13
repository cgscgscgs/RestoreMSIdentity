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

        public DbSet<SiteOverviewModelCopy> SiteOverviewCopies { get; set; } // celina added this 2/12, step 4 of connecting azure sql db
        //added/
        public DbSet<LandingPageModel> LandingPage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SiteModel>().HasData(
                new SiteModel { Id = 1, Name = "Site A", Description = "Site A", ImageUrl = "/images/siteA.jpg" },
                new SiteModel { Id = 2, Name = "Site B", Description = "This i an awesome site", ImageUrl = "/images/siteB.jpg" },
                new SiteModel { Id = 3, Name = "Site C", Description = "This is a river and woods", ImageUrl = "/images/siteC.jpg" }
            );
            modelBuilder.Entity<LandingPageModel>().HasData(
                new LandingPageModel { Id = 1, Name = "River Place", Description = "Planting trees will cool water temperatures for hatchlings.", Location = "1234 Address", ImageUrl = "/images/imageA.jpg" },
                new LandingPageModel { Id = 2, Name = "Weedy Bog", Description = "Clearing this bog of weeds will allow young salmon to flourish.", Location = "1234 Address", ImageUrl = "/images/imageA.jpg" },
                new LandingPageModel { Id = 3, Name = "Dude's Backyard", Description = "This trash heap drains into the Green River.", Location = "1234 Address", ImageUrl = "/images/imageA.jpg" }
            );
        }
    }
}
