using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CoronaWedding.Data;
using CoronaWedding.Models;
using Microsoft.AspNetCore.Http;

namespace CoronaWedding.Controllers
{
    public class PhotographersController : Controller
    {
        private readonly WeddingCoronaContext _context;

        public PhotographersController(WeddingCoronaContext context)
        {
            _context = context;
        }

        // GET: Photographers
        public async Task<IActionResult> Index()
        {
            string isAdmin = HttpContext.Session.GetString("Type");
            ViewBag.IsAdmin = isAdmin != null && isAdmin.Equals("Admin");
            return View(await _context.Photographer.ToListAsync());
        }

        // GET: Photographers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photographer = await _context.Photographer
                .FirstOrDefaultAsync(m => m.PhotographerId == id);
            if (photographer == null)
            {
                return NotFound();
            }


            return View(photographer);
        }

        // GET: Photographers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Photographers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhotographerId,supplireEmail,imagePath,price")] Photographer photographer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(photographer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(photographer);
        }

        // GET: Photographers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photographer = await _context.Photographer.FindAsync(id);
            if (photographer == null)
            {
                return NotFound();
            }
            return View(photographer);
        }

        // POST: Photographers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhotographerId,supplireEmail,imagePath,price")] Photographer photographer)
        {
            if (id != photographer.PhotographerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(photographer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhotographerExists(photographer.PhotographerId))
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
            return View(photographer);
        }

        // GET: Photographers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photographer = await _context.Photographer
                .FirstOrDefaultAsync(m => m.PhotographerId == id);
            if (photographer == null)
            {
                return NotFound();
            }

            return View(photographer);
        }

        // POST: Photographers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var photographer = await _context.Photographer.FindAsync(id);
            _context.Photographer.Remove(photographer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhotographerExists(int id)
        {
            return _context.Photographer.Any(e => e.PhotographerId == id);
        }
    }
}
