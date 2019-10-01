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
    public class ReportStatusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportStatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReportStatus
        public async Task<IActionResult> Index()
        {
            return View(await _context.ReportStatus.ToListAsync());
        }

        // GET: ReportStatus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportStatus = await _context.ReportStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reportStatus == null)
            {
                return NotFound();
            }

            return View(reportStatus);
        }

        // GET: ReportStatus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReportStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ReportStatusName")] ReportStatus reportStatus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportStatus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportStatus);
        }

        // GET: ReportStatus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportStatus = await _context.ReportStatus.FindAsync(id);
            if (reportStatus == null)
            {
                return NotFound();
            }
            return View(reportStatus);
        }

        // POST: ReportStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ReportStatusName")] ReportStatus reportStatus)
        {
            if (id != reportStatus.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportStatus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportStatusExists(reportStatus.Id))
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
            return View(reportStatus);
        }

        // GET: ReportStatus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportStatus = await _context.ReportStatus
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reportStatus == null)
            {
                return NotFound();
            }

            return View(reportStatus);
        }

        // POST: ReportStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportStatus = await _context.ReportStatus.FindAsync(id);
            _context.ReportStatus.Remove(reportStatus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportStatusExists(int id)
        {
            return _context.ReportStatus.Any(e => e.Id == id);
        }
    }
}
