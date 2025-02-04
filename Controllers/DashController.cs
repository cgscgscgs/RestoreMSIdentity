using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestoreMSIdentity.Data;
using RestoreMSIdentity.Models;

namespace RestoreMSIdentity.Controllers
{
    public class DashboardController : Controller
    {

        private readonly AppDBContext _context;

        public DashboardController(AppDBContext context)
        {
            _context = context;
        }
        //public IActionResult DashboardView()
        //{
        //    if (!_context.Sites.Any()) // Avoid duplicate seeding
        //    {
        //        var sites = new List<SiteModel>
        //         {
        //             new SiteModel { Id = 1, Name = "Site A", Description = "Site A", ImageUrl = "/images/siteA.jpg" },
        //             new SiteModel { Id = 2, Name = "Site B", Description = "This i an awesome site", ImageUrl = "/images/siteB.jpg" },
        //             new SiteModel { Id = 3, Name = "Site C", Description = "This is a river and woods", ImageUrl = "/images/siteC.jpg" }
        //         };

        //        _context.Sites.AddRange(sites);
        //        _context.SaveChanges();
        //    }

        //    return Content("Dummy data has been added successfully.");
        //}

        //public IActionResult DashboardView()
        //{
        //    var sites = new List<SiteModel>
        //    {
        //        new SiteModel { Id = 1, Name = "Site A", Description = "Site A", ImageUrl = "/images/siteA.jpg" },
        //        new SiteModel { Id = 2, Name = "Site B", Description = "This i an awesome site", ImageUrl = "/images/siteB.jpg" },
        //        new SiteModel { Id = 3, Name = "Site C", Description = "This is a river and woods", ImageUrl = "/images/siteC.jpg" }
        //    };

        //    return View(sites);
        //}

        public IActionResult DashboardView()
        {
            var sites = _context.Sites.ToList();
            return View(sites);
        }
    }

}



//private readonly AppDBContext _context;

//public DashController(AppDBContext context)
//{
//    _context = context;
//}
//public IActionResult DashboardView()
//{
//    if (!_context.Sites.Any()) // Avoid duplicate seeding
//    {
//        var sites = new List<SiteModel>
//         {
//             new SiteModel { Id = 1, Name = "Site A", Description = "Site A", ImageUrl = "/images/siteA.jpg" },
//             new SiteModel { Id = 2, Name = "Site B", Description = "This i an awesome site", ImageUrl = "/images/siteB.jpg" },
//             new SiteModel { Id = 3, Name = "Site C", Description = "This is a river and woods", ImageUrl = "/images/siteC.jpg" }
//         };

//        _context.Sites.AddRange(sites);
//        _context.SaveChanges();
//    }

//    return Content("Dummy data has been added successfully.");
//}