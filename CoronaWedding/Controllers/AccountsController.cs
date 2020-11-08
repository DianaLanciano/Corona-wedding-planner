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
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Authorization;
using SQLitePCL;

namespace CoronaWedding.Controllers
{
    public class AccountsController : Controller
    {
        private readonly WeddingCoronaContext _context;

        public AccountsController(WeddingCoronaContext context)
        {
            _context = context;
        }

        // GET: Accounts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Account.ToListAsync());
        }
        public async Task<IActionResult> Checkout()
        {


            string userId = HttpContext.Session.GetString("userId");
            var user = _context.Account.Where(a => a.AccountId.ToString() == userId)
                .Include(c => c.Catering).Include(l => l.Location).Include(m => m.Music)
                .Include(p => p.Photographer).SingleOrDefault();
            if (user == null)
            {
                return RedirectToAction("Index","Home");
            }

            ViewBag.LocationPrice = user.Location != null ? user.Location.price : 0;
            ViewBag.CateringPrice = user.Catering != null ? user.Catering.price : 0;
            ViewBag.MusicPrice = user.Music != null ? user.Music.price : 0;
            ViewBag.PhotographerPrice = user.Location != null ? user.Photographer.price : 0;
            ViewBag.Total = ViewBag.LocationPrice + ViewBag.CateringPrice + ViewBag.MusicPrice + ViewBag.PhotographerPrice;
            return View(user);
        }

        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .FirstOrDefaultAsync(m => m.AccountId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }


        // GET: Accounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccountId,Email,password,weddingDate")] Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }
        //edit my profile
        public IActionResult editProfile()
        {
           string profileId = HttpContext.Session.GetString("userId");
            if (profileId == null)
            {
                return RedirectToAction("Login");
            }
            return RedirectToAction("Edit", "Accounts", new { id = profileId });
        }
        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //no session
            if (HttpContext.Session.GetString("Type") == null)
            {
                return RedirectToAction("Login", "Accounts");
            }

            bool isAdmin = HttpContext.Session.GetString("Type").Equals("Admin");
            string profileId = HttpContext.Session.GetString("userId");

            //user is Mamber - can edit only is profile
            if ((!isAdmin) && id.ToString() != profileId)
            {
                return RedirectToAction("Edit", "Accounts", new { id = profileId });
            }
          

            var account = await _context.Account.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccountId,Email,password,weddingDate")] Account account)
        {
            if (id != account.AccountId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.AccountId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                if (HttpContext.Session.GetString("Type").Equals("Admin"))
                    return RedirectToAction(nameof(Index));
                else { return RedirectToAction("Index", "Home"); }
            }
            return View(account);
        }

        private bool AccountExists(int id)
        {
            return _context.Account.Any(e => e.AccountId == id);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("Type") == null)
            {
                return RedirectToAction("Login", "Accounts");
            }
            if (isAdmin())
            {
                return RedirectToAction("Index", "Home");
            }

            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .FirstOrDefaultAsync(m => m.AccountId == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Account.FindAsync(id);
            _context.Account.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        /*********************Login and registration whith session**********************************/

        // GET: Users/Signup
        public IActionResult Signup()
        {
            return View();
        }

        // POST: Users/Signup
        [HttpPost]
        public async Task<IActionResult> Signup(string email, string password, DateTime date)
        {
            if (ModelState.IsValid)
            {
                if (email == null || password == null)
                {
                    ViewData["error"] = "Fill in all Details!";
                    return View();
                }

                var ifEmailExist = (from u in _context.Account
                                    where u.Email.ToUpper() == email.ToUpper()
                                    select new { email }).FirstOrDefault();

                if (ifEmailExist != null)
                {
                    ViewData["error"] = "Email already exist";
                    return View();
                }

                Account user = new Account()
                {
                    Email = email,
                    password = password,
                    weddingDate = date
                };

                _context.Account.Add(user);
                await _context.SaveChangesAsync();
                SignIn(user);
                return RedirectToAction("Index","Home");


            }
            return View();
        }
        // Signin user and starts the session.
        private void SignIn(Account account)
        {
            HttpContext.Session.SetString("Type", account.Type.ToString());
            HttpContext.Session.SetString("userId", account.AccountId.ToString());
        }

        // GET: Accounts/Login
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Account.FirstOrDefault(u => u.Email == email && u.password == password);

            if (user != null)
            {
                SignIn(user);
                return RedirectToAction("Index", "Home");
            }


            //in case user is null
            ViewData["error"] = "Email not exist";
            return View();
        }
        public IActionResult Logout()
        {
            string user = HttpContext.Session.GetString("userId");

            if (user != null)
            {
                HttpContext.Session.Clear();
            }

            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> addToCart(string itemType, int itemId)
        {
            string userId = HttpContext.Session.GetString("userId");
            string userType = HttpContext.Session.GetString("Type");

            //if user not logged in
            if (userId == null || userType == null)
            {
                // return RedirectToAction(nameof(Login), "Accounts");
                return Json(new { result = "Redirect", url = Url.Action("Login", "Accounts") });
            }
            //find the user whith this userId(Email)
            var user = _context.Account.FirstOrDefault(u => u.AccountId.ToString().Equals(userId));
            if (user == null)
            {
                //return RedirectToAction("Login","Accounts");
                return Json(new { result = "Redirect", url = Url.Action("Login", "Accounts") });
            }

            switch (itemType)
            {
                case "Catering": user.CateringId = itemId; break;
                case "Location": user.LocationId = itemId; break;
                case "Music": user.MusicId = itemId; break;
                case "Photographer": user.PhotographerId = itemId; break;
                default: return RedirectToAction("Index", "Home");
            }

            _context.Update(user);
            await _context.SaveChangesAsync();
            return Json(new { succes = true });
        }

        public bool isAdmin()
        {
            string isAdmin = HttpContext.Session.GetString("Type");
            return isAdmin.Equals("Admin");
        }


        /*******************************Admin Dashboard***********************************************************/
        public async Task<IActionResult> Dashboard()
        {
            if (HttpContext.Session.GetString("Type") == null)
            {
                return RedirectToAction("Login", "Accounts");
            }
            if (!HttpContext.Session.GetString("Type").Equals("Admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            return View(await _context.Account.ToListAsync());
        }

        public async Task<IActionResult> searchBox(string term)
        {
            var query = from user in _context.Account
                        where user.Email.Contains(term)
                        select new {id = user.AccountId, label = user.Email, value = user.password };


            return Json(await _context.Account.ToListAsync());
        }

    }
}
