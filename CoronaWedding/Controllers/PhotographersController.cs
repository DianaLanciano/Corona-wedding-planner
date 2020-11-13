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
            if (HttpContext.Session.GetString("userId") != null)
            {
                string userId = HttpContext.Session.GetString("userId");
                var userAccount = _context.Account.Where(a => a.AccountId.ToString() == userId).FirstOrDefault();
                var r = this.recommennded(userAccount);
                var sortedDict = (from entry in r orderby entry.Value.score descending select entry.Value).Take(3).ToList();
                ViewBag.recommended = sortedDict;
            }
            string isAdmin = HttpContext.Session.GetString("Type");
            ViewBag.IsAdmin = isAdmin != null && isAdmin.Equals("Admin");
            return View(await _context.Photographer.ToListAsync());
        }
        /***************Recommended**********************/
        public Dictionary<string, Recommend> recommennded(Account account)
        {
            Dictionary<string, Recommend> recommended = new Dictionary<string, Recommend>();
            var users = _context.Account.Include(p => p.Photographer);
            foreach (Account u in users)
            {
                if (u.PhotographerId != null)
                {
                    string photoKey = u.PhotographerId.ToString();
                    int score = 0;

                    if (u.LocationId == account.LocationId)
                    { score++; }
                    if (u.CateringId == account.CateringId)
                    { score++; }
                    if (u.MusicId == account.MusicId)
                    { score++; }

                    if (recommended.ContainsKey(photoKey))
                    {
                        recommended[photoKey].score += score;
                    }
                    else
                    {
                        if (score != 0)
                        {
                            recommended.Add(photoKey, new Recommend() { score = score, Photographer = u.Photographer });
                        }
                    }
                }
            }
            return recommended;
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
            if (HttpContext.Session.GetString("userId") == null)
            {
                return RedirectToAction("Login", "Accounts");
            }
            if (!HttpContext.Session.GetString("Type").Equals("Admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        // POST: Photographers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhotographerId,supplierEmail,imagePath,price")] Photographer photographer)
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
        public async Task<IActionResult> Edit(int id, [Bind("PhotographerId,supplierEmail,imagePath,price")] Photographer photographer)
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
            if (HttpContext.Session.GetString("Type") == null)
            {
                return RedirectToAction("Login", "Accounts");
            }
            if (!HttpContext.Session.GetString("Type").Equals("Admin"))
            {
                return RedirectToAction("Index", "Home");
            }
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
            var accountsWhithPhotographer = _context.Account
            .Where(l => l.PhotographerId == id);
            foreach (var l in accountsWhithPhotographer)
            {
                l.PhotographerId = null;
            }

            var photographer = await _context.Photographer.FindAsync(id);
            _context.Photographer.Remove(photographer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhotographerExists(int id)
        {
            return _context.Photographer.Any(e => e.PhotographerId == id);
        }

        /***************For Dashboard**********************/
        public async Task<IActionResult> List()
        {
            if (HttpContext.Session.GetString("Type") == null)
            {
                return RedirectToAction("Login", "Accounts");
            }
            if (!HttpContext.Session.GetString("Type").Equals("Admin"))
            {
                return RedirectToAction("Login", "Accounts");
            }
            return View(await _context.Photographer.ToListAsync());



        }



        
       
    }
}
