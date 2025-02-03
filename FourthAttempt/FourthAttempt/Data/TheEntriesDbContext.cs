using Microsoft.EntityFrameworkCore;
using FourthAttempt.Models;

namespace FourthAttempt.Data
{
    public class TheEntriesDbContext : DbContext
    {
        public TheEntriesDbContext(DbContextOptions<TheEntriesDbContext> options) : base(options) { }

        public TheEntriesDbContext() { }

        public DbSet<TheEntriesList> Entries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=TheSiteEntriesDB;Integrated Security=True;TrustServerCertificate=True;");
            }

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TheEntriesList>().ToTable("entries"); 
            // Make sure the name matches exactly
                                                                     
            //  modelBuilder.Entity<TheEntriesList>()
                                                                       
            //  .HasKey(e => e.SiteEntryID); // ✅ Explicitly set SiteEntryID as the primary key
        }

    }
}
