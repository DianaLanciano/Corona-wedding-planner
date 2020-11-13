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
using System.Reflection.Metadata.Ecma335;
using Newtonsoft.Json;

namespace CoronaWedding.Controllers
{
    public class LocationsController : Controller
    {
        private readonly WeddingCoronaContext _context;

        public LocationsController(WeddingCoronaContext context)
        {
            _context = context;
        }

        // GET: Locations(also advance search)
        public async Task<IActionResult> Index(string? id, string? area, string? city, double? fprice, double? tprice, bool? filtered)
        {
            List<Location> locations = _context.Location.ToList();
            if (filtered != null)
            {
                if (area != null)
                {
                    locations = locations.Where(l => l.area.Equals(area)).ToList();
                }
                if (city != null)
                {
                    locations = locations.Where(l => l.city.Equals(city)).ToList();
                }
                if (city != null)
                {
                    locations = locations.Where(l => l.city.Equals(city)).ToList();
                }
                if (fprice != null)
                {
                    locations = locations.Where(c => c.price >= fprice).ToList();
                }
                if (tprice != null)
                {
                    locations = locations.Where(c => c.price <= tprice).ToList();
                }
            }
            else
            {
                if (id == null || id == "all")
                    locations = await _context.Location.ToListAsync();
                else
                {
                    var result = from l in _context.Location
                                 where l.area.Equals(id)
                                 select l;
                    locations = result.ToList();
                }
            }
            string isAdmin = HttpContext.Session.GetString("Type");
            ViewBag.IsAdmin = isAdmin != null && isAdmin.Equals("Admin");

            ViewBag.area = area;
            ViewBag.city = city;
            ViewBag.fromPrice = fprice;
            ViewBag.toPrice = tprice;

            return View(locations);
        }
        // GET: Locations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.Location
                .FirstOrDefaultAsync(m => m.LocationId == id);
            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // GET: Locations/Create
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

        // POST: Locations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocationId,placeCapacity,supplierEmail,area,city,map,imagePath,price,Latitude,Longitude")] Location location)
        {
            if (ModelState.IsValid)
            {
                _context.Add(location);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(location);
        }

        // GET: Locations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.Location.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }
            return View(location);
        }

        // POST: Locations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LocationId,placeCapacity,supplierEmail,area,city,map,imagePath,price")] Location location)
        {
            if (id != location.LocationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(location);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationExists(location.LocationId))
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
            return View(location);
        }

        // GET: Locations/Delete/5
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

            var location = await _context.Location
                .FirstOrDefaultAsync(m => m.LocationId == id);
            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accountsWhithLocation = _context.Account
               .Where(l => l.LocationId == id);
            foreach (var l in accountsWhithLocation)
            {
                l.LocationId = null;
            }

            var location = await _context.Location.FindAsync(id);
            _context.Location.Remove(location);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationExists(int id)
        {
            return _context.Location.Any(e => e.LocationId == id);
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
            return View(await _context.Location.ToListAsync());
        }

        /***************advance search**********************/
        public IActionResult advanceSearch(string area)
        {
            var cities = from c in _context.Location
                         where c.area.Equals(area)
                         select c;

            ViewBag.Cities = cities;
            return View(cities);
        }


    }
}
