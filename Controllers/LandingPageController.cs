using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestoreMSIdentity.Data;
using RestoreMSIdentity.Models;

namespace RestoreMSIdentity.Controllers
{
    public class LandingPageController : Controller
    {
        //public IActionResult LandingPage()
        //{
        //    var tiles = new List<LandingPageModel>
        //        {
        //        new LandingPageModel { Id = 1, Name = "River Place", Description = "Planting trees will cool water temperatures for hatchlings.", Location = "1234 Address", ImageUrl = "/images/imageA.jpg" },
        //        new LandingPageModel { Id = 2, Name = "Weedy Bog", Description = "Clearing this bog of weeds will allow young salmon to flourish.", Location = "1234 Address", ImageUrl = "/images/imageA.jpg" },
        //        new LandingPageModel { Id = 3, Name = "Dude's Backyard", Description = "This trash heap drains into the Green River.", Location = "1234 Address", ImageUrl = "/images/imageA.jpg" },
        //        };
        //    return View(tiles);
        //}


        private readonly AppDBContext _context;

        public LandingPageController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult LandingPage()
        {
            var LandingPage = _context.LandingPage.ToList();
            return View(LandingPage);
        }
    }
}


/*   OLDER VERSIONS:


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestoreMSIdentity.Data;
using RestoreMSIdentity.Models;

namespace RestoreMSIdentity.Controllers
{
    public class LandingPageController : Controller
    {
        //editing 2/13 - Kari
        private readonly AppDBContext _context;

        public LandingPageController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> LandingPage()
        {
            return View(await _context.Tiles.ToListAsync());
        }


        /* OLD VERSION 2/12:
         * 
         * public IActionResult LandingPage()
        {
            var tiles = new List<LandingPageModel>
                {
                new LandingPageModel { Id = 1, Name = "River Place", Description = "Planting trees will cool water temperatures for hatchlings.", Location = "1234 Address", ImageUrl = "/images/imageA.jpg" },
                new LandingPageModel { Id = 2, Name = "Weedy Bog", Description = "Clearing this bog of weeds will allow young salmon to flourish.", Location = "1234 Address", ImageUrl = "/images/imageA.jpg" },
                new LandingPageModel { Id = 3, Name = "Dude's Backyard", Description = "This trash heap drains into the Green River.", Location = "1234 Address", ImageUrl = "/images/imageA.jpg" },
                };
            return View(tiles);
        } 
       
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Location,ImageURL")] LandingPageModel landingPageModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(landingPageModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(landingPageModel);
        }
        //end edits - Kari 2/13
    }
}



/* PREVIOUS VER: 
 *          var data = new LandingPageModel() { Name = "Green River Worksite" };
            return View(data);
*/