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
                new LandingPageModel { Id = 1, Name = "Sign Up", Description = "Volunteer with us!", ImageUrl = "/images/imageA.jpg" },
                new LandingPageModel { Id = 2, Name = "Log In", Description = "Log in to the Restore Dashboard", ImageUrl = "/images/imageA.jpg" },
                new LandingPageModel { Id = 3, Name = "About Us", Description = "Who is the Green River Coalition?", ImageUrl = "/images/imageA.jpg" },
                new LandingPageModel { Id = 4, Name = "Events", Description = "See what we are doing next!", ImageUrl = "/images/imageA.jpg" },
                new LandingPageModel { Id = 4, Name = "Tile 5", Description = "Blurb", ImageUrl = "/images/imageA.jpg" },
                new LandingPageModel { Id = 4, Name = "Tile 6", Description = "Blurb", ImageUrl = "/images/imageA.jpg" }
                };
            return View(tiles);
        }
    }
}


/* PREVIOUS VER: 
 *          var data = new LandingPageModel() { Name = "Green River Worksite" };
            return View(data);
*/