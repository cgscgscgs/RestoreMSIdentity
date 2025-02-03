using Microsoft.AspNetCore.Mvc;
using RestoreMSIdentity.Models;


namespace RestoreMSIdentity.Controllers
{

    public class DashboardController : Controller
    {

        public IActionResult DashboardView()
        
        {
            var sites = new List<SiteModel>
        {
            new SiteModel { Id = 1, Name = "Site A", Description = "Site A", ImageUrl = "/images/siteA.jpg" },
            new SiteModel { Id = 2, Name = "Site B", Description = "This i an awesome site", ImageUrl = "/images/siteB.jpg" },
            new SiteModel { Id = 3, Name = "Site C", Description = "This is a river and woods", ImageUrl = "/images/siteC.jpg" }
        };

            return View(sites);
        }
    }
}
