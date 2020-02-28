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
    public class TicketsController : Controller
    {
        private readonly MotoGPcontext _context;

        public TicketsController(MotoGPcontext context)
        {
            _context = context;
        }

        // GET: Tickets
        public async Task<IActionResult> Index()
        {
            var motoGPcontext = _context.Tickets.Include(t => t.Country).Include(t => t.Race);
            return View(await motoGPcontext.ToListAsync());
        }

        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .Include(t => t.Country)
                .Include(t => t.Race)
                .FirstOrDefaultAsync(m => m.TicketID == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "CountryID");
            ViewData["RaceID"] = new SelectList(_context.Races, "RaceID", "RaceID");
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TicketID,Name,Email,Addresss,CountryID,RaceID,Number,OrderDate,Paid")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "CountryID", ticket.CountryID);
            ViewData["RaceID"] = new SelectList(_context.Races, "RaceID", "RaceID", ticket.RaceID);
            return View(ticket);
        }

        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "CountryID", ticket.CountryID);
            ViewData["RaceID"] = new SelectList(_context.Races, "RaceID", "RaceID", ticket.RaceID);
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicketID,Name,Email,Addresss,CountryID,RaceID,Number,OrderDate,Paid")] Ticket ticket)
        {
            if (id != ticket.TicketID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.TicketID))
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
            ViewData["CountryID"] = new SelectList(_context.Countries, "CountryID", "CountryID", ticket.CountryID);
            ViewData["RaceID"] = new SelectList(_context.Races, "RaceID", "RaceID", ticket.RaceID);
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Tickets
                .Include(t => t.Country)
                .Include(t => t.Race)
                .FirstOrDefaultAsync(m => m.TicketID == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _context.Tickets.Any(e => e.TicketID == id);
        }
    }
}
