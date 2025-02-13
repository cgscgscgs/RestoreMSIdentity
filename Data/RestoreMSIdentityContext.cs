/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RestoreMSIdentity.Models;

namespace RestoreMSIdentity.Data
{
    public class RestoreMSIdentityContext : DbContext
    {
        public RestoreMSIdentityContext (DbContextOptions<RestoreMSIdentityContext> options)
            : base(options)
        {
        }

        public DbSet<RestoreMSIdentity.Models.SiteOverviewModel> SiteOverviewModel { get; set; } = default!;
    }
}
*/