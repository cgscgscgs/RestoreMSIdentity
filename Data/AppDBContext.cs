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
    }
}
