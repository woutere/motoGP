using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using motoGP.Data;
using motoGP.Models;

namespace motoGP.wwwroot
{
    public class RidersController : Controller
    {
        private readonly MotoGPcontext _context;

        public RidersController(MotoGPcontext context)
        {
            _context = context;
        }

        // GET: Riders
        public async Task<IActionResult> Index()
        {
            var motoGPcontext = _context.Riders.Include(r => r.Country).Include(r => r.Team);
            return View(await motoGPcontext.ToListAsync());
        }

        // GET: Riders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rider = await _context.Riders
                .Include(r => r.Country)
                .Include(r => r.Team)
                .FirstOrDefaultAsync(m => m.RiderId == id);
            if (rider == null)
            {
                return NotFound();
            }

            return View(rider);
        }

        // GET: Riders/Create
        public IActionResult Create()
        {
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "CountryID");
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamID");
            return View();
        }

        // POST: Riders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RiderId,LastName,FirstName,CountryID,TeamID,Bike,Number")] Rider rider)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "CountryID", rider.CountryID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamID", rider.TeamID);
            return View(rider);
        }

        // GET: Riders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rider = await _context.Riders.FindAsync(id);
            if (rider == null)
            {
                return NotFound();
            }
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "CountryID", rider.CountryID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamID", rider.TeamID);
            return View(rider);
        }

        // POST: Riders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RiderId,LastName,FirstName,CountryID,TeamID,Bike,Number")] Rider rider)
        {
            if (id != rider.RiderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RiderExists(rider.RiderId))
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
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "CountryID", rider.CountryID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "TeamID", "TeamID", rider.TeamID);
            return View(rider);
        }

        // GET: Riders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rider = await _context.Riders
                .Include(r => r.Country)
                .Include(r => r.Team)
                .FirstOrDefaultAsync(m => m.RiderId == id);
            if (rider == null)
            {
                return NotFound();
            }

            return View(rider);
        }

        // POST: Riders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rider = await _context.Riders.FindAsync(id);
            _context.Riders.Remove(rider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RiderExists(int id)
        {
            return _context.Riders.Any(e => e.RiderId == id);
        }
    }
}
