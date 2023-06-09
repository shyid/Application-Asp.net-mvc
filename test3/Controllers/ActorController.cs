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
using Microsoft.AspNetCore.Authorization;

namespace test3.Controllers
{
    // [Route("[controller]")]
    public class ActorController : Controller
    {
        private readonly test3IdentityDbContext _context;

        public ActorController(test3IdentityDbContext context)
        {
            _context = context;

        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allActors = await _context.Actors.ToListAsync();
            return View(allActors);
        }

        // Get:Actor/Create
        public IActionResult Create()
        {
            // IEnumerable<Actor> viewActors = _context.Actors.ToList();
            return View();
        }
        [HttpPost]
        // post:Actor/Create
        public async Task<IActionResult> Create(Actor obj)
        {
            if (!ModelState.IsValid)
            {
                // Console.WriteLine(obj.FullName + " "+ obj.Bio+" "+obj.ProfilePictureURL+" "+obj.Id+obj.actor_Movies);
                return View(obj);
            }
            await  _context.AddAsync(obj);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        // Get:Actor/Edit/id
        public IActionResult Details(int? id)
        {
            if(id == null || id==0) return NotFound();
            var ViewActor = _context.Actors.ToList().FirstOrDefault(d=>d.Id == id);
            if(ViewActor == null) return NotFound();
            // IEnumerable<Actor> viewActors = _context.Actors.ToList();
            return View(ViewActor);
        }

        // Get:Actor/Edit/id
        public IActionResult Edit(int? id)
        {
            if(id == null || id==0) return NotFound();
            var ViewActor = _context.Actors.Find(id);
            if(ViewActor == null) return NotFound();
            // IEnumerable<Actor> viewActors = _context.Actors.ToList();
            return View(ViewActor);
        }
        [HttpPost]
        // post:Actor/Edit/id
        public async Task<IActionResult> Edit(int? id,Actor obj)
        {
            if (!ModelState.IsValid)
            {
                // Console.WriteLine(obj.FullName + " "+ obj.Bio+" "+obj.ProfilePictureURL+" "+obj.Id+obj.actor_Movies);
                return View(obj);
            }
            _context.Update(obj);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
                // Get:Actor/Delete/id
        public IActionResult Delete(int? id)
        {
            if(id == null || id==0) return NotFound();
            var ViewActor = _context.Actors.Find(id);
            if(ViewActor == null) return NotFound();
            // IEnumerable<Actor> viewActors = _context.Actors.ToList();
            return View(ViewActor);
        }
        [HttpPost]
        // post:Actor/Delete/id
        public async Task<IActionResult> DeletePost(int? id)
        {
            if(id == null || id==0) return NotFound();
            var ViewActor = _context.Actors.Find(id);
            if(ViewActor == null) return NotFound();
            _context.Remove(ViewActor);
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