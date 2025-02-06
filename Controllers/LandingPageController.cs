using Microsoft.AspNetCore.Mvc;
using RestoreMSIdentity.Models;

namespace RestoreMSIdentity.Controllers
{
    public class LandingPageController : Controller
    {
        public IActionResult LandingPage()
        {
            var tiles = new List<LandingPageModel>
                {
                new LandingPageModel { Id = 1, Name = "River Place", Description = "Planting trees will cool water temperatures for hatchlings.", Location = "1234 Address", ImageUrl = "/images/imageA.jpg" },
                new LandingPageModel { Id = 2, Name = "Weedy Bog", Description = "Clearing this bog of weeds will allow young salmon to flourish.", Location = "1234 Address", ImageUrl = "/images/imageA.jpg" },
                new LandingPageModel { Id = 3, Name = "Dude's Backyard", Description = "This trash heap drains into the Green River.", Location = "1234 Address", ImageUrl = "/images/imageA.jpg" },
                };
            return View(tiles);
        }
    }
}


/* PREVIOUS VER: 
 *          var data = new LandingPageModel() { Name = "Green River Worksite" };
            return View(data);
*/