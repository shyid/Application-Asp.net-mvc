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
    public class ProducerController : Controller
    {
        private readonly test3IdentityDbContext _context;

        public ProducerController(test3IdentityDbContext context)
        {
            _context = context;

        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producers.ToListAsync();
            return View(allProducers);
        }
        // Get:Producer/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        // post: Producer/Create
        public async Task<IActionResult> Create( Producer obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            await  _context.AddAsync(obj);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        // Get: Producer/Edit/id
        public IActionResult Details(int? id)
        {
            if(id == null || id==0) return NotFound();
            var viewProducer = _context. Producers.ToList().FirstOrDefault(d=>d.Id == id);
            if(viewProducer == null) return NotFound();
            return View(viewProducer);
        }

        // Get: Producer/Edit/id
        public IActionResult Edit(int? id)
        {
            if(id == null || id==0) return NotFound();
            var viewProducer = _context. Producers.Find(id);
            if(viewProducer == null) return NotFound();
            return View(viewProducer);
        }
        [HttpPost]
        // post: Producer/Edit/id
        public async Task<IActionResult> Edit(int? id, Producer obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            _context.Update(obj);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        // Get: Producer/Delete/id
        public IActionResult Delete(int? id)
        {
            if(id == null || id==0) return NotFound();
            var viewProducer = _context. Producers.Find(id);
            if(viewProducer == null) return NotFound();
            return View(viewProducer);
        }
        [HttpPost]
        // post: Producer/Delete/id
        public async Task<IActionResult> DeletePost(int? id)
        {
            if(id == null || id==0) return NotFound();
            var viewProducer = _context. Producers.Find(id);
            if(viewProducer == null) return NotFound();
            _context.Remove(viewProducer);
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