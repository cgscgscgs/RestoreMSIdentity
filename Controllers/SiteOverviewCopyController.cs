/* date            developer               changes
 *  2/12/2025        celina                 copied SiteOverviewController.cs, step 2 of connecting to azure sql database
 *  2/12/2025        celina                 made a basic index page, and then needed to add create page
 * 
 */



using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RestoreMSIdentity.Data;
using RestoreMSIdentity.Models;

namespace RestoreMSIdentity.Controllers
{
    public class SiteOverviewCopyController : Controller
    {
        private readonly AppDBContext _context;

        public SiteOverviewCopyController(AppDBContext context)
        {
            _context = context;
        }

        // GET: SiteOverviewCopy
        public IActionResult Index()
        {
            return View();
        }

        // GET: SiteOverviewCopy/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SiteOverviewCopy/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,OwnershipType,City,Status,StartDate")] SiteOverviewModelCopy siteOverviewModelCopy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(siteOverviewModelCopy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(siteOverviewModelCopy);
        }
    }
}



/*
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestoreMSIdentity.Data;
using RestoreMSIdentity.Models;

namespace RestoreMSIdentity.Controllers
{
    public class SiteOverviewCopyController : Controller // changed this from Sample that copilot gave called products, to SiteOverviewCopyController
    {
        private readonly AppDBContext _context; // changed this from YourDbContext to AppDBContext

        public SiteOverviewCopyController(AppDBContext context) // changed this from YourDbContext to AppDBContext
                                                                // and ProductsController to SiteOverviewCopyController
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.SiteOverviewCopy.ToListAsync()); // changed this from Products to SiteOverviewCopy
        }

        // Other actions (Create, Edit, Details, Delete) go here
    }
}
*/