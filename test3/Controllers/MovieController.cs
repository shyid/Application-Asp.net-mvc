using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test3.Models;
using test3.Areas.Identity.Data;

namespace test3.Controllers
{
    public class MovieController :Controller 
    {
        private readonly test3IdentityDbContext _db;
        public  MovieController(test3IdentityDbContext db){
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _db.Movies.Include(a=>a.cinema).ToListAsync();
            return View(allMovies);
        }

        // Get
        // Get:Movie/Create
        public IActionResult Create()
        {
            // IEnumerable<Movie> viewMovies = _db.Movies.ToList();
            return View();
        }
        [HttpPost]
        // post:Movie/Create
        public async Task<IActionResult> Create(NewMovieVM obj)
        {
            if (!ModelState.IsValid)
            {
                // Console.WriteLine(obj.FullName + " "+ obj.Bio+" "+obj.ProfilePictureURL+" "+obj.Id+obj.Movie_Movies);
                return View(obj);
            }
            var newMovie = new Movie(){
                Name = obj.Name,
                Description = obj.Description,
                Price = obj.Price,
                ImageURL = obj.ImageURL,
                StartDate = obj.StartDate,
                EndDate = obj.EndDate,
                MovieCategory =obj.MovieCategory,
                producerId = obj.ProducerId
            };
            await  _db.Movies.AddAsync(newMovie);
            await _db.SaveChangesAsync();
            // Relationship
            foreach (var actorId in (dynamic)obj.ActorId)
            {
                var newActorMovie = new  Actor_Movie(){
                    MovieId = newMovie.Id,
                    ActorId = actorId
                };
                await  _db.Actors_Movies.AddAsync(newActorMovie);
            }
            
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        // Get:Movie/Edit/id
        public IActionResult Details(int? id)
        {
            if(id == null || id==0) return NotFound();
            var ViewMovie = _db.Movies.Include(c=>c.cinema).
            Include(p=>p.producer)
            .Include(am=>am.actor_Movies).ThenInclude(a=>a.actor)
            .ToList().FirstOrDefault(d=>d.Id == id);
            if(ViewMovie == null) return NotFound();
            // IEnumerable<Movie> viewMovies = _db.Movies.ToList();
            return View(ViewMovie);
        }

        // Get:Movie/Edit/id
        public IActionResult Edit(int? id)
        {
            if(id == null || id==0) return NotFound();
            var ViewMovie = _db.Movies.Find(id);
            if(ViewMovie == null) return NotFound();
            // IEnumerable<Movie> viewMovies = _db.Movies.ToList();
            return View(ViewMovie);
        }
        [HttpPost]
        // post:Movie/Edit/id
        public async Task<IActionResult> Edit(int? id,Movie obj)
        {
            if (!ModelState.IsValid)
            {
                // Console.WriteLine(obj.FullName + " "+ obj.Bio+" "+obj.ProfilePictureURL+" "+obj.Id+obj.Movie_Movies);
                return View(obj);
            }
            _db.Update(obj);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
                // Get:Movie/Delete/id
        public IActionResult Delete(int? id)
        {
            if(id == null || id==0) return NotFound();
            var ViewMovie = _db.Movies.Find(id);
            if(ViewMovie == null) return NotFound();
            // IEnumerable<Movie> viewMovies = _db.Movies.ToList();
            return View(ViewMovie);
        }
        [HttpPost]
        // post:Movie/Delete/id
        public async Task<IActionResult> DeletePost(int? id)
        {
            if(id == null || id==0) return NotFound();
            var ViewMovie = _db.Movies.Find(id);
            if(ViewMovie == null) return NotFound();
            _db.Remove(ViewMovie);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
       
       
    }
}