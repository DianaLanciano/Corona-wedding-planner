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
using Microsoft.AspNetCore.Authorization;

namespace CoronaWedding.Controllers
{
    public class CateringsController : Controller
    {
        private readonly WeddingCoronaContext _context;

        public CateringsController(WeddingCoronaContext context)
        {
            _context = context;
        }

        // GET: Caterings
        public async Task<IActionResult> Index(string? id)
        {
            List<Catering> caterings;
            if (id == null || id == "all")
                caterings = await _context.Catering.ToListAsync();
            else {
                var result = from c in _context.Catering
                             where c.foodType.Equals(id)
                             select c;
                caterings = result.ToList();
            }
            string isAdmin = HttpContext.Session.GetString("Type");
            ViewBag.IsAdmin = isAdmin != null && isAdmin.Equals("Admin");

            return View(caterings);
        }

        // GET: Caterings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catering = await _context.Catering
                .FirstOrDefaultAsync(m => m.CateringId == id);
            if (catering == null)
            {
                return NotFound();
            }

            return View(catering);
        }

        // GET: Caterings/Create
        
        public IActionResult Create()
        {
            return View();
        }

        // POST: Caterings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CateringId,foodType,supplireEmail,price,imagePath")] Catering catering)
        {
            if (ModelState.IsValid)
            {
                _context.Add(catering);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(catering);
        }

        // GET: Caterings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catering = await _context.Catering.FindAsync(id);
            if (catering == null)
            {
                return NotFound();
            }
            return View(catering);
        }

        // POST: Caterings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CateringId,foodType,supplireEmail,price,imagePath")] Catering catering)
        {
            if (id != catering.CateringId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(catering);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CateringExists(catering.CateringId))
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
            return View(catering);
        }

        // GET: Caterings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var catering = await _context.Catering
                .FirstOrDefaultAsync(m => m.CateringId == id);
            if (catering == null)
            {
                return NotFound();
            }

            return View(catering);
        }

        // POST: Caterings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var catering = await _context.Catering.FindAsync(id);
            _context.Catering.Remove(catering);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CateringExists(int id)
        {
            return _context.Catering.Any(e => e.CateringId == id);
        }


        /***************For Dashboard**********************/
        public async Task<IActionResult> List()
        {
            return View(await _context.Catering.ToListAsync());
        }
    }
}
