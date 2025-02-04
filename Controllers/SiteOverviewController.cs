/* date         developer           changes
 * 2/3/2025     celina              created SiteOverviewController.cs
 * 
 * 
 * 
 * */

using Microsoft.AspNetCore.Mvc;

namespace RestoreMSIdentity.Controllers
{
    // This class is a controller that handles requests to the site overview page.
    public class SiteOverviewController : Controller
    {



        // Every public method in a controller is callable as an HTTP endpoint.
        // This method returns the view for the site overview page in Views/SiteOverview/Index.cshtml.
        public IActionResult Index()
        {
            return View();
        }
    }
}
