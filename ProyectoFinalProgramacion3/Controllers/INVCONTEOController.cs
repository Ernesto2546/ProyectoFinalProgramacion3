using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinalProgramacion3.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinalProgramacion3.Controllers
{
    public class INVCONTEOController : Controller
    {
        public readonly ApplicationDbContext _db;
        public INVCONTEOController(ApplicationDbContext db)
        {
            _db = db; 
        }
        // GET: INVCONTEOController
        public async Task<ActionResult> Index()
        {
            IEnumerable<INVCONTEO> invconteo = await _db.INVCONTEO.ToListAsync(); 
            return View(invconteo);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(INVCONTEO invconteo)
        {
            if (ModelState.IsValid)
            {
                if (INVCONTEO.DESCRIPCION.Length == 0)
                {
                    await _db.DESCRIPCION.AddAsync(invconteo);
                    await _db.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return View(invconteo);
            }
        }
       
        // GET: INVCONTEOController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // GET: INVCONTEOController/Create


        // POST: INVCONTEOController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
       

        // GET: INVCONTEOController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: INVCONTEOController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: INVCONTEOController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: INVCONTEOController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
