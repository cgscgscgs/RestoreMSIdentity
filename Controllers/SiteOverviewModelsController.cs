/*  date                    developer               changes
 *  2/3/2025                celina                  created SiteOverviewModelsController.cs
 * 
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestoreMSIdentity.Data;
using RestoreMSIdentity.Models;

namespace RestoreMSIdentity.Controllers
{
    public class SiteOverviewModelsController : Controller
    {
        private readonly RestoreMSIdentityContext _context;

        public SiteOverviewModelsController(RestoreMSIdentityContext context)
        {
            _context = context;
        }

        // GET: SiteOverviewModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.SiteOverviewModel.ToListAsync());
        }

        // GET: SiteOverviewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siteOverviewModel = await _context.SiteOverviewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (siteOverviewModel == null)
            {
                return NotFound();
            }

            return View(siteOverviewModel);
        }

        // GET: SiteOverviewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SiteOverviewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,OwnershipType,City,Status,StartDate")] SiteOverviewModel siteOverviewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(siteOverviewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(siteOverviewModel);
        }

        // GET: SiteOverviewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siteOverviewModel = await _context.SiteOverviewModel.FindAsync(id);
            if (siteOverviewModel == null)
            {
                return NotFound();
            }
            return View(siteOverviewModel);
        }

        // POST: SiteOverviewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,OwnershipType,City,Status,StartDate")] SiteOverviewModel siteOverviewModel)
        {
            if (id != siteOverviewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(siteOverviewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SiteOverviewModelExists(siteOverviewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(siteOverviewModel);
        }

        // GET: SiteOverviewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var siteOverviewModel = await _context.SiteOverviewModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (siteOverviewModel == null)
            {
                return NotFound();
            }

            return View(siteOverviewModel);
        }

        // POST: SiteOverviewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var siteOverviewModel = await _context.SiteOverviewModel.FindAsync(id);
            if (siteOverviewModel != null)
            {
                _context.SiteOverviewModel.Remove(siteOverviewModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SiteOverviewModelExists(int id)
        {
            return _context.SiteOverviewModel.Any(e => e.Id == id);
        }
    }
}
