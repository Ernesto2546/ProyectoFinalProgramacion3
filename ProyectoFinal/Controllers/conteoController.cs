using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class conteoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public conteoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: conteo
        public async Task<IActionResult> Index()
        {
            return View(await _context.INVCONTEO.ToListAsync());
        }

        // GET: conteo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iNVCONTEO = await _context.INVCONTEO
                .FirstOrDefaultAsync(m => m.Id == id);
            if (iNVCONTEO == null)
            {
                return NotFound();
            }

            return View(iNVCONTEO);
        }

        // GET: conteo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: conteo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DESCRIPCION,CANTIDAD")] INVCONTEO iNVCONTEO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(iNVCONTEO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iNVCONTEO);
        }

        // GET: conteo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iNVCONTEO = await _context.INVCONTEO.FindAsync(id);
            if (iNVCONTEO == null)
            {
                return NotFound();
            }
            return View(iNVCONTEO);
        }

        // POST: conteo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DESCRIPCION,CANTIDAD")] INVCONTEO iNVCONTEO)
        {
            if (id != iNVCONTEO.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iNVCONTEO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!INVCONTEOExists(iNVCONTEO.Id))
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
            return View(iNVCONTEO);
        }

        // GET: conteo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iNVCONTEO = await _context.INVCONTEO
                .FirstOrDefaultAsync(m => m.Id == id);
            if (iNVCONTEO == null)
            {
                return NotFound();
            }

            return View(iNVCONTEO);
        }

        // POST: conteo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iNVCONTEO = await _context.INVCONTEO.FindAsync(id);
            if (iNVCONTEO != null)
            {
                _context.INVCONTEO.Remove(iNVCONTEO);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool INVCONTEOExists(int id)
        {
            return _context.INVCONTEO.Any(e => e.Id == id);
        }
    }
}
