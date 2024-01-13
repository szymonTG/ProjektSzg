using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjektSzg.Data;
using ProjektSzg.Models;

namespace ProjektSzg.Controllers
{
    [Authorize(Roles ="Admin,User")]
    public class BookRentalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookRentalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BookRentals
        public async Task<IActionResult> Index()
        {
              return _context.TableBookRentals != null ? 
                          View(await _context.TableBookRentals.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TableBookRentals'  is null.");
        }

        // GET: BookRentals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TableBookRentals == null)
            {
                return NotFound();
            }

            var bookRentals = await _context.TableBookRentals
                .FirstOrDefaultAsync(m => m.rentalId == id);
            if (bookRentals == null)
            {
                return NotFound();
            }

            return View(bookRentals);
        }

        // GET: BookRentals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookRentals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("rentalId,startDate,endDate,userId,bookId")] BookRentals bookRentals)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookRentals);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookRentals);
        }

        // GET: BookRentals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TableBookRentals == null)
            {
                return NotFound();
            }

            var bookRentals = await _context.TableBookRentals.FindAsync(id);
            if (bookRentals == null)
            {
                return NotFound();
            }
            return View(bookRentals);
        }

        // POST: BookRentals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("rentalId,startDate,endDate,userId,bookId")] BookRentals bookRentals)
        {
            if (id != bookRentals.rentalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookRentals);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookRentalsExists(bookRentals.rentalId))
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
            return View(bookRentals);
        }

        // GET: BookRentals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TableBookRentals == null)
            {
                return NotFound();
            }

            var bookRentals = await _context.TableBookRentals
                .FirstOrDefaultAsync(m => m.rentalId == id);
            if (bookRentals == null)
            {
                return NotFound();
            }

            return View(bookRentals);
        }

        // POST: BookRentals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TableBookRentals == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TableBookRentals'  is null.");
            }
            var bookRentals = await _context.TableBookRentals.FindAsync(id);
            if (bookRentals != null)
            {
                _context.TableBookRentals.Remove(bookRentals);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookRentalsExists(int id)
        {
          return (_context.TableBookRentals?.Any(e => e.rentalId == id)).GetValueOrDefault();
        }
    }
}
