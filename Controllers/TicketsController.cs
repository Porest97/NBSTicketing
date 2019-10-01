using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NBSTicketing.Data;
using NBSTicketing.Models.DataModels;

namespace NBSTicketing.Controllers
{
    public class TicketsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TicketsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tickets
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Ticket
                .Include(t => t.AssignedFE)
                .Include(t => t.Order)
                .Include(t => t.OrderBy)
                .Include(t => t.TicketStatus)
                .Include(t => t.TicketType)
                .Include(t => t.Location);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket
                .Include(t => t.AssignedFE)
                .Include(t => t.Order)
                .Include(t => t.OrderBy)
                .Include(t => t.TicketStatus)
                .Include(t => t.TicketType)
                .Include(t => t.Location)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
        public IActionResult Create()
        {
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["OrderId"] = new SelectList(_context.Set<Order>(), "Id", "OrderNumber");
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName");
            ViewData["TicketStatusId"] = new SelectList(_context.Set<TicketStatus>(), "Id", "TicketStatusName");
            ViewData["TicketTypeId"] = new SelectList(_context.Set<TicketType>(), "Id", "TicketTypeName");
            ViewData["SiteId"] = new SelectList(_context.Set<Site>(), "Id", "SiteName");
            return View();
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TicketCreated,TicketStartTime,TicketEndTime,PersonId,OrderId,PersonId1,FESceduled,FEOnSite,FELeavingSite,TicketTypeId,TicketDescription,TicketStatusId,SiteId")] Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ticket);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", ticket.PersonId1);
            ViewData["OrderId"] = new SelectList(_context.Set<Order>(), "Id", "OrderNumber", ticket.OrderId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", ticket.PersonId);
            ViewData["TicketStatusId"] = new SelectList(_context.Set<TicketStatus>(), "Id", "TicketStatusName", ticket.TicketStatusId);
            ViewData["TicketTypeId"] = new SelectList(_context.Set<TicketType>(), "Id", "TicketTypeName", ticket.TicketTypeId);
            ViewData["SiteId"] = new SelectList(_context.Set<Site>(), "Id", "SiteName", ticket.SiteId);
            return View(ticket);
        }

        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", ticket.PersonId1);
            ViewData["OrderId"] = new SelectList(_context.Set<Order>(), "Id", "OrderNumber", ticket.OrderId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", ticket.PersonId);
            ViewData["TicketStatusId"] = new SelectList(_context.Set<TicketStatus>(), "Id", "TicketStatusName", ticket.TicketStatusId);
            ViewData["TicketTypeId"] = new SelectList(_context.Set<TicketType>(), "Id", "TicketTypeName", ticket.TicketTypeId);
            ViewData["SiteId"] = new SelectList(_context.Set<Site>(), "Id", "SiteName", ticket.SiteId);
            return View(ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TicketCreated,TicketStartTime,TicketEndTime,PersonId,OrderId,PersonId1,FESceduled,FEOnSite,FELeavingSite,TicketTypeId,TicketDescription,TicketStatusId,SiteId")] Ticket ticket)
        {
            if (id != ticket.Id)
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
                    if (!TicketExists(ticket.Id))
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
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "FullName", ticket.PersonId1);
            ViewData["OrderId"] = new SelectList(_context.Set<Order>(), "Id", "OrderNumber", ticket.OrderId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", ticket.PersonId);
            ViewData["TicketStatusId"] = new SelectList(_context.Set<TicketStatus>(), "Id", "TicketStatusName", ticket.TicketStatusId);
            ViewData["TicketTypeId"] = new SelectList(_context.Set<TicketType>(), "Id", "TicketTypeName", ticket.TicketTypeId);
            ViewData["SiteId"] = new SelectList(_context.Set<Site>(), "Id", "SiteName", ticket.SiteId);
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket
                .Include(t => t.AssignedFE)
                .Include(t => t.Order)
                .Include(t => t.OrderBy)
                .Include(t => t.TicketStatus)
                .Include(t => t.TicketType)
                .Include(t => t.Location)
                .FirstOrDefaultAsync(m => m.Id == id);
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
            var ticket = await _context.Ticket.FindAsync(id);
            _context.Ticket.Remove(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _context.Ticket.Any(e => e.Id == id);
        }
    }
}
