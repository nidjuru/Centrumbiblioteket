using Centrumbiblioteket.Data;
using Centrumbiblioteket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Centrumbiblioteket.Controllers
{
    public class LateRentalsController : Controller
    {
        private readonly Context _context;

        public LateRentalsController(Context context)
        {
            _context = context;
        }

        // GET: LateRentals
            public async Task<IActionResult> Index()
            {
                var context = _context.Rentals
                       .Include(r => r.Customer)
                       .Include(r => r.Inventory)
                       .ThenInclude(r => r.Book)
                       .Where(r => r.ReturnDate > DateTime.Now).Include(r => r.Inventory);//Returndate är på 30 dagar, ändrar sen till mindre än för att uppnå funktionaliteten som efterfrågas.
                return View(await context.ToListAsync());
            }

        // GET: LateRentals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rental = await _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Inventory)
                .FirstOrDefaultAsync(m => m.RentalId == id);
            if (rental == null)
            {
                return NotFound();
            }

            return View(rental);
        }

        // GET: LateRentals/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerFirstName");
            ViewData["InventoryId"] = new SelectList(_context.Inventories, "InventoryId", "InventoryId");
            return View();
        }

        // POST: LateRentals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentalId,InventoryId,RentalDate,ReturnDate,Rented,CustomerId")] Rental rental)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rental);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerFirstName", rental.CustomerId);
            ViewData["InventoryId"] = new SelectList(_context.Inventories, "InventoryId", "InventoryId", rental.InventoryId);
            return View(rental);
        }

        // GET: LateRentals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rental = await _context.Rentals.FindAsync(id);
            if (rental == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerFirstName", rental.CustomerId);
            ViewData["InventoryId"] = new SelectList(_context.Inventories, "InventoryId", "InventoryId", rental.InventoryId);
            return View(rental);
        }

        // POST: LateRentals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RentalId,InventoryId,RentalDate,ReturnDate,Rented,CustomerId")] Rental rental)
        {
            if (id != rental.RentalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rental);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalExists(rental.RentalId))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "CustomerId", "CustomerFirstName", rental.CustomerId);
            ViewData["InventoryId"] = new SelectList(_context.Inventories, "InventoryId", "InventoryId", rental.InventoryId);
            return View(rental);
        }

        // GET: LateRentals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rental = await _context.Rentals
                .Include(r => r.Customer)
                .Include(r => r.Inventory)
                .FirstOrDefaultAsync(m => m.RentalId == id);
            if (rental == null)
            {
                return NotFound();
            }

            return View(rental);
        }

        // POST: LateRentals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rental = await _context.Rentals.FindAsync(id);
            _context.Rentals.Remove(rental);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalExists(int id)
        {
            return _context.Rentals.Any(e => e.RentalId == id);
        }
    }
}
