using FourthAttempt.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using FourthAttempt.Models;

namespace FourthAttempt.Controllers
{
    public class EntriesController : Controller
    {
        private readonly TheEntriesDbContext _context;

        public EntriesController(TheEntriesDbContext context)
        {
            _context = context;
        }

        // display all entries (viewing/reading) 
        public async Task<IActionResult> Index()
        {
            var entries = await _context.Entries.ToListAsync();
            return View(entries);
        }

        // Create a site entry through a form
        public IActionResult Create()
        {
            return View();
        }

        //Save an entry to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TheEntriesList entry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));


            }
            return View(entry);
        }

        //Edit an entry or update a saved entry 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TheEntriesList entry)
        {
            if (id != entry.SiteEntryID) return NotFound(); // 🔹 Fix: No need for int.Parse()

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entry);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Entries.Any(e => e.SiteEntryID == id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return View(entry);
        }
        // 📌 Delete (GET) - Confirm Deletion
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var entry = await _context.Entries.FindAsync(id);
            if (entry == null) return NotFound();
            return View(entry);
        }

        // 📌 Delete (POST) - Remove Entry from Database
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entry = await _context.Entries.FindAsync(id);
            if (entry != null)
            {
                _context.Entries.Remove(entry);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
    }
