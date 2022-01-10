using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MLT.Data;
using MLT.Models;

namespace MLT.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminFlightPathsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminFlightPathsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminFlightPaths
        public async Task<IActionResult> Index()
        {
            return View(await _context.FlightPath.ToListAsync());
        }

        // GET: Admin/AdminFlightPaths/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightPath = await _context.FlightPath
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flightPath == null)
            {
                return NotFound();
            }

            return View(flightPath);
        }

        // GET: Admin/AdminFlightPaths/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminFlightPaths/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FlightID,Origin,Destination")] FlightPath flightPath)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flightPath);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flightPath);
        }

        // GET: Admin/AdminFlightPaths/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightPath = await _context.FlightPath.FindAsync(id);
            if (flightPath == null)
            {
                return NotFound();
            }
            return View(flightPath);
        }

        // POST: Admin/AdminFlightPaths/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FlightID,Origin,Destination")] FlightPath flightPath)
        {
            if (id != flightPath.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flightPath);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightPathExists(flightPath.Id))
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
            return View(flightPath);
        }

        // GET: Admin/AdminFlightPaths/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flightPath = await _context.FlightPath
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flightPath == null)
            {
                return NotFound();
            }

            return View(flightPath);
        }

        // POST: Admin/AdminFlightPaths/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flightPath = await _context.FlightPath.FindAsync(id);
            _context.FlightPath.Remove(flightPath);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightPathExists(int id)
        {
            return _context.FlightPath.Any(e => e.Id == id);
        }
    }
}
