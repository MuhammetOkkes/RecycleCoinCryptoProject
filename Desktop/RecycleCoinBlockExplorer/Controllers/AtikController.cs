using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecycleCoinBlockExplorer.Data;
using RecycleCoinBlockExplorer.Models.Entity;

namespace RecycleCoinBlockExplorer.Controllers
{
    public class AtikController : Controller
    {
        private readonly DataContext _context;

        public AtikController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> AddAtik(Atik atik)
        {
            _context.Atiklar.Add(atik);
            await _context.SaveChangesAsync();
            return View();
        }

        // GET: Atik
        public async Task<IActionResult> Index()
        {
              return View(await _context.Atiklar.ToListAsync());
        }

        // GET: Atik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Atiklar == null)
            {
                return NotFound();
            }

            var atik = await _context.Atiklar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atik == null)
            {
                return NotFound();
            }

            return View(atik);
        }

        // GET: Atik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Atik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Adi,Miktar,CarbonDegeri,Id")] Atik atik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(atik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(atik);
        }

        // GET: Atik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Atiklar == null)
            {
                return NotFound();
            }

            var atik = await _context.Atiklar.FindAsync(id);
            if (atik == null)
            {
                return NotFound();
            }
            return View(atik);
        }

        // POST: Atik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Adi,Miktar,CarbonDegeri,Id")] Atik atik)
        {
            if (id != atik.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(atik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AtikExists(atik.Id))
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
            return View(atik);
        }

        // GET: Atik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Atiklar == null)
            {
                return NotFound();
            }

            var atik = await _context.Atiklar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (atik == null)
            {
                return NotFound();
            }

            return View(atik);
        }

        // POST: Atik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Atiklar == null)
            {
                return Problem("Entity set 'DataContext.Atiklar'  is null.");
            }
            var atik = await _context.Atiklar.FindAsync(id);
            if (atik != null)
            {
                _context.Atiklar.Remove(atik);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AtikExists(int id)
        {
          return _context.Atiklar.Any(e => e.Id == id);
        }
    }
}
