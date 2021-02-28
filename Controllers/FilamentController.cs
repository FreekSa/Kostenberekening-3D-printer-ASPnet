using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kostenberekening_3D_printer_ASPnet.Models;

namespace Kostenberekening_3D_printer_ASPnet.Controllers
{
    public class FilamentController : Controller
    {
        private readonly FilamentenlijstContext _context;

        public FilamentController(FilamentenlijstContext context)
        {
            _context = context;
        }

        // GET: Filament
        public async Task<IActionResult> Index()
        {
            return View(await _context.Filamenten.ToListAsync());
        }

        // GET: Filament/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filament = await _context.Filamenten
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filament == null)
            {
                return NotFound();
            }

            return View(filament);
        }

        // GET: Filament/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Filament/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type,Kleur,KostPerRol,AantalKg")] Filament filament)
        {
            if (ModelState.IsValid)
            {
                _context.Add(filament);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(filament);
        }

        // GET: Filament/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filament = await _context.Filamenten.FindAsync(id);
            if (filament == null)
            {
                return NotFound();
            }
            return View(filament);
        }

        // POST: Filament/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type,Kleur,KostPerRol,AantalKg")] Filament filament)
        {
            if (id != filament.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filament);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilamentExists(filament.Id))
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
            return View(filament);
        }

        // GET: Filament/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filament = await _context.Filamenten
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filament == null)
            {
                return NotFound();
            }

            return View(filament);
        }

        // POST: Filament/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var filament = await _context.Filamenten.FindAsync(id);
            _context.Filamenten.Remove(filament);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilamentExists(int id)
        {
            return _context.Filamenten.Any(e => e.Id == id);
        }
    }
}
