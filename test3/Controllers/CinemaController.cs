using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using test3.Areas.Identity.Data;
using test3.Models;
namespace test3.Controllers
{
    // [Route("[controller]")]
    public class CinemaController : Controller
    {

        private readonly test3IdentityDbContext _context;

        public CinemaController(test3IdentityDbContext context)
        {
            _context = context;

        }

        public async Task<IActionResult> Index()
        {
            var allCinmas = await _context.Cinemas.ToListAsync();
            return View(allCinmas);
        }
        // Get:Cinema/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        // post:Cinema/Create
        public async Task<IActionResult> Create(Cinema obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            await  _context.AddAsync(obj);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        // Get:Cinema/Edit/id
        public IActionResult Details(int? id)
        {
            if(id == null || id==0) return NotFound();
            var viewCinema = _context.Cinemas.ToList().FirstOrDefault(d=>d.Id == id);
            if(viewCinema == null) return NotFound();
            return View(viewCinema);
        }

        // Get:Cinema/Edit/id
        public IActionResult Edit(int? id)
        {
            if(id == null || id==0) return NotFound();
            var viewCinema = _context.Cinemas.Find(id);
            if(viewCinema == null) return NotFound();
            return View(viewCinema);
        }
        [HttpPost]
        // post:Cinema/Edit/id
        public async Task<IActionResult> Edit(int? id,Cinema obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            _context.Update(obj);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        // Get:Cinema/Delete/id
        public IActionResult Delete(int? id)
        {
            if(id == null || id==0) return NotFound();
            var viewCinema = _context.Cinemas.Find(id);
            if(viewCinema == null) return NotFound();
            return View(viewCinema);
        }
        [HttpPost]
        // post:Cinema/Delete/id
        public async Task<IActionResult> DeletePost(int? id)
        {
            if(id == null || id==0) return NotFound();
            var viewCinema = _context.Cinemas.Find(id);
            if(viewCinema == null) return NotFound();
            _context.Remove(viewCinema);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}